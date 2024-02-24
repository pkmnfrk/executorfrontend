using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutorFrontend
{
    internal class Instance
    {
        public Process Process { get; set; }
        public DateTime LastTasOutput { get; set; }
        public int Id { get; set; }
        public StreamReader LogStream { get; set; }
    }
}
