Executor Frontend
=================

This is a tool meant to assist bruteforcing efforts on the Portal 2 TAS discord. However,
technically it is more generic than that.

Given a command and a working directory, it will run the command a specified number of times, and
make a best effort to keep that number running at all times. You may optionally specify a period
with a different number (eg, for overnight efforts).

Any time the current number of running instances does not match the desired number it will spin up a
new instance or kill an old instance as appropriate. This is performed at most once per minute so as
to not cause extra load on the computer.

Special support is built in for Portal 2 TASsing specifically, enabling the "stuck instance" check. 
This will enable logging in the Source instance, and monitor the log for TAS-related output. If it
doesn't see any for a given period, it will assume the instance is dead and kill it. It will then be
respawned by the usual mechanisms.

I'm open to adding new features if anyone is interested!

Settings
--------

Username: What username to report to the TAS server (only relevant for Portal 2 TASing)
Command: What command to execute. Specify the executable name directly, do not prefix with `start`.
         This is expected to be a long-running task.
Working Dir: Where to run the command
Instances: How many copies of the command to keep running.
Restart stuck processes: Monitor the logs for output to ensure the process is still running. If not,
                         they will be restarted (only relevant for Portal 2 TASing). Can specify the
                         how long to wait before considering a process dead
Min time between actions: How long, in seconds, to wait before doing multiple actions. Eg, if
                          it wants to spawn 3 processes, it will wait this long between each one to
                          avoid overloading the system.
Enable Night Mode: During the hours specified, use the number of instances specified here instead of
                   the normal count.

Known issues
------------

* New windows will always be spawned in the foreground on the current desktop. Fixing this is non
  trivial, but I would like to try.
* The stuck instance prevention can't tell if it is the server that breaks, rather than a single
  instance. Manual intervention might be required in this case.
* If upgrading from an older version, the settings might be erased. This is caused by me changing
  the wrong version number. I'm sorry, it won't happen again ;_;

  
