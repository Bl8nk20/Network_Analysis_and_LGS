using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary
{

    interface IDataManipulatior<T, V>
    {
        V Manipulate(T data);
    }

    internal class Data_Manipulation
    {
    }
}
