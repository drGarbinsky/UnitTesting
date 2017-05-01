using DataSource;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStuff
{

    public class Formatter
    {
        public string GetFormatedOutput(IDataSource src)
        {
            var procId = src.GetProcId();
            return string.Format("Current Process ID: {0}", procId);
        }
    }


    public class Printer
    {
        private Formatter formatter;
        private ProcessIdSource source;

        public Printer(Formatter fmt, ProcessIdSource src)
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
