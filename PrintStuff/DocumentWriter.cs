using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintStuff
{
    public class DocumentWriter
    {
        public Dictionary<int, string> output = new Dictionary<int, string>();
        public string fileName = "";

        public DocumentWriter()
        {
            
        }

        public void WriteAllText(int id, string message)
        {
            output.Add(id, message);
            fileName = $".\\{id}-output.txt.";
            var writer = File.CreateText(fileName);
            writer.WriteLine(message);
        }

    }
}
