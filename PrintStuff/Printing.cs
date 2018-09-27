using DataSource;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private IDataSource source;

        public Printer(Formatter fmt, IDataSource src)
        {
            this.formatter = fmt;
            this.source = src;
        }


        /// <summary>
        /// Do not change this method signature. 
        /// </summary>
        public void Print()
        {
            var id = this.source.GetProcId();
            var message = this.formatter.GetFormatedOutput(this.source);
            var filename = $".\\output-{id}.txt";
            if (id % 2 == 0)
            {
                //Statics are inherently untestable
                //imagine this is a call to an external system
                File.WriteAllText(filename, message);
            }
        }
    }
}
