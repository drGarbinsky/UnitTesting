using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStuff
{
    /// <summary>
    /// a stand-in for an external service like a DB
    /// </summary>
    public class DataSource
    {
        public int GetProcId()
        {
            // pretend this is some complex stuff that can't be done in a unit tests
            return Process.GetCurrentProcess().Id;
        }
    }




    public class Formatter
    {
        public string GetFormatedOutput(DataSource src)
        {
            var procId = src.GetProcId();
            return string.Format("Current Process ID: {0}", procId);
        }
    }


    public class Printer
    {
        private Formatter formatter;
        private DataSource source;

        public Printer(Formatter fmt, DataSource src)
        {
            this.formatter = fmt;
            this.source = src;
        }

        public void Print()
        {
            var id = this.source.GetProcId();
            var message = this.formatter.GetFormatedOutput(this.source);
            Console.WriteLine(message);
        }
    }
}
