using DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStuff
{
    class DataSourceTest : IDataSource
    {
        int IDataSource.GetProcId()
        {
            return 200;
        }
    }
}
