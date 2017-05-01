using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
   public  class ProcessIdSource :IDataSource
    {
        public int GetProcId()
        {
            // pretend this is some complex stuff that can't be done in a unit tests
            return Process.GetCurrentProcess().Id;
        }
    }

    public interface IDataSource
    {
        int GetProcId();
    }
}
