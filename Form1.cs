﻿using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ExecutorFrontend
{
    public partial class Form1 : Form
    {
        private List<Instance> processes = new List<Instance>();
        private bool freshStart = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void chkNightMode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.nightModeEnabled = chkNightMode.Checked;
            Properties.Settings.Default.Save();
        }

        private void cmdChooseDir_Click(object sender, EventArgs e)
        {
            using (var selector = new CommonOpenFileDialog())
            {
                selector.InitialDirectory = txtWorkDir.Text;
                selector.IsFolderPicker = true;
                var result = selector.ShowDialog();
                if(result == CommonFileDialogResult.Ok)
                {
                    txtWorkDir.Text = selector.FileName;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCommand.Text = Properties.Settings.Default.command;
            txtWorkDir.Text = Properties.Settings.Default.workDir;
            numDayCount.Value = Properties.Settings.Default.instanceCount;
            chkNightMode.Checked = Properties.Settings.Default.nightModeEnabled;
            numNightCount.Value = Properties.Settings.Default.nightModeCount;
            numStartHour.Value = Properties.Settings.Default.nightModeStart;
            numEndHour.Value = Properties.Settings.Default.nightModeEnd;
            chkShowWindows.Checked = Properties.Settings.Default.showWindows;
            chkRestartStuck.Checked = Properties.Settings.Default.restartStuck;
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.command = txtCommand.Text;
            Properties.Settings.Default.Save();
        }

        private void txtWorkDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.workDir = txtWorkDir.Text;
            Properties.Settings.Default.Save();
        }

        private void numDayCount_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.instanceCount = (int)numDayCount.Value;
            Properties.Settings.Default.Save();
        }

        private void numStartHour_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.nightModeStart = (int)numStartHour.Value;
            Properties.Settings.Default.Save();
        }

        private void numEndHour_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.nightModeEnd = (int)numEndHour.Value;
            Properties.Settings.Default.Save();
        }

        private void numNightCount_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.nightModeCount = (int)numNightCount.Value;
            Properties.Settings.Default.Save();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if(tmrRefresh.Enabled)
            {
                DoEnd();
            } else
            {
                DoStart();
            }
        }

        private void DoStart()
        {
            // make sure the working directory is valid
            if(string.IsNullOrWhiteSpace(txtWorkDir.Text))
            {
                return;
            }

            if(!Directory.Exists(txtWorkDir.Text))
            {
                MessageBox.Show("The provided directory does not exist, please check it and try again", "Starting");
                return;
            }

            freshStart = true;
            tmrRefresh.Enabled = true;
            chkRestartStuck.Enabled = false;
            txtCommand.Enabled = false;
            txtWorkDir.Enabled = false;
            chkShowWindows.Enabled = false;
            cmdStart.Text = "Stop (kills instances)";
            
            Log($"Beginning update timer");
            Tick();
        }

        private void DoEnd()
        {
            tmrRefresh.Enabled = false;
            cmdStart.Text = "Start";
            chkRestartStuck.Enabled = true;
            txtCommand.Enabled = true;
            txtWorkDir.Enabled = true;
            chkShowWindows.Enabled = true;
            Log($"Stopping update timer, and killing {processes.Count} processes");
            KillProcesses();
        }

        private void KillProcesses()
        {
            foreach (var proc in processes)
            {
                KillInstance(proc);
            }

            processes.Clear();
        }

        private void Log(string msg)
        {
            var entry = $"[{DateTime.Now:HH:mm:ss}] {msg}\r\n";
            txtLog.Text += entry;
            txtLog.Select(txtLog.Text.Length - 1, 0);
            txtLog.ScrollToCaret();
            File.AppendAllText("log.txt", entry);
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        private void Tick()
        {
            // Log("Tick");
            // first, evaluate all processes to make sure they're still runnning
            var dead = new List<Instance>();
            foreach (var proc in processes)
            {
                if (proc.Process.HasExited)
                {
                    dead.Add(proc);
                    Log($"Process {proc.Process.Id} has terminated unexpectedly. Curious");
                }
                else if(chkRestartStuck.Checked)
                {
                    
                    var newOutput = proc.LogStream.ReadToEnd();
                    if(newOutput.Contains("TAS "))
                    {
                        proc.LastTasOutput = DateTime.Now;
                    }

                    if (proc.LastTasOutput < DateTime.Now.AddMinutes(-2))
                    {
                        Log($"Have not detected any TAS-related output for instance #{proc.Id}, killing it");
                        //KillInstance(proc);
                        //dead.Add(proc);
                    }
                }
            }

            foreach (var proc in dead)
            {
                processes.Remove(proc);
            }

            // next, figure out our desired count
            var desired = IsNightMode ? numNightCount.Value : numDayCount.Value;

        onFreshStart:
            if (processes.Count < desired)
            {
                Log($"Not enough processes running ({processes.Count}, but we want {desired}), starting new one");

                var parts = txtCommand.Text.Split(new char[] { ' ' }, 2);
                try
                {
                    var nextId = GetNextId();
                    StreamReader streamReader = null;
                    if (chkRestartStuck.Checked)
                    {
                        var logFile = Path.Combine(txtWorkDir.Text, "portal2", $"instance_{nextId}.log");
                        if (File.Exists(logFile))
                        {
                            File.Copy(logFile, Path.Combine(txtWorkDir.Text, "portal2", $"instance_{nextId}.old.log"), true);
                        }

                        var stream = new FileStream(logFile, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                        streamReader = new StreamReader(stream, Encoding.UTF8);
                    }

                    var proc = new Process();
                    proc.StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = txtWorkDir.Text,
                        //UseShellExecute = true,
                        //WindowStyle = chkShowWindows.Checked ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        FileName = $"{Path.Combine(txtWorkDir.Text, parts[0])}",
                        Arguments = GetCommandLine(nextId),
                    };
                    proc.Start();
                    processes.Add(new Instance
                    {
                        Process = proc,
                        LastTasOutput = DateTime.Now,
                        Id = nextId,
                        LogStream = streamReader,
                    });

                    //if (freshStart)
                    //{
                    //    goto onFreshStart;
                    //}
                } catch(Exception ex)
                {
                    Log($"Unable to start a new process. Check your command and try again: {ex.Message}");
                }
            }

            freshStart = false;

            if(processes.Count > desired && processes.Count > 0)
            {
                Log($"Too many processes running ({processes.Count}, but we want {desired}), killing oldest one");
                var proc = processes[0];
                KillInstance(proc);
                processes.Remove(proc);

            }
        }

        private bool IsNightMode
        {
            get
            {
                if (!chkNightMode.Checked) return false;
                if(numStartHour.Value > numEndHour.Value)
                {
                    // spans midnight 🙄
                    return DateTime.Now.Hour >= numStartHour.Value || DateTime.Now.Hour < numEndHour.Value;
                } else
                {
                    return DateTime.Now.Hour >= numStartHour.Value && DateTime.Now.Hour < numEndHour.Value;
                }
            }
        }

        private int GetNextId()
        {
            var id = 1;
            while(IsIdUsed(id))
            {
                id++;
                if(id >= 100)
                {
                    throw new Exception("Too many ids, what the hell");
                }
            }

            return id;
        }

        private bool IsIdUsed(int id)
        {
            foreach (var proc in processes)
            {
                if (proc.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private string GetCommandLine(int id)
        {
            var parts = txtCommand.Text.Split(new char[] { ' ' }, 2);
            if(chkRestartStuck.Checked) {
                return $"{parts[1]} -condebug +con_logfile instance_{id}.log";
            }

            return parts[1];
        }

        private void KillInstance(Instance inst)
        {
            if (!inst.Process.HasExited)
            {
                try
                {
                    inst.Process.Kill();
                }
                catch (Exception ex)
                {
                    Log(ex.Message);
                }
            }

            if(inst.LogStream != null)
            {
                inst.LogStream.Close();
                inst.LogStream = null;
            }
        }

        private void chkShowWindows_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.showWindows = chkShowWindows.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmrRefresh.Enabled && processes.Count > 0)
            {
                var result = MessageBox.Show("Instances are currently running, this will close them. Is that okay?", "Closing", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    KillProcesses();
                }
            }
        }

        private void chkRestartStuck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.restartStuck = chkRestartStuck.Checked;
        }
    }
}