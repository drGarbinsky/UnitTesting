using DataSource;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStuff
{
    /// <summary>
    /// A simple stand-in for a more complex real world class.
    /// </summary>
    public class Formatter
    {
        public string GetFormatedOutput(IDataSource src)
        {
            var procId = src.GetProcId();

            // this is a very simple method but is a stand in for something more real world.
            // Imgine that something more complex is being done here.
            return string.Format("Current Process ID: {0}", procId);
        }
    }


    public class Printer
    {

        // These to private fields represent tight coupling 
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
