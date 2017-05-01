using DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ProcessIdSource();
            var formatter = new Formatter();
            var printer = new Printer(formatter, data);
            printer.Print();
        }
    }
}
