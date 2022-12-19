using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary
{

    interface IDataGathering<T>
    {
        IEnumerable<T> GetData();
    }

    internal class Data_Gathering
    {
    }
}
