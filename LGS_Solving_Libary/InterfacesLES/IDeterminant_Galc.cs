using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.InterfacesLES
{
    internal interface IDeterminant_Galc<out T, in V>
    {
        /* Creating a Interface for the Determinant Calculation
         * 
         * Needed: matrix
         * 
         * Calculating: double
         */

        public double[,] _matrix { get; set; }

        T CalculatingDet(V data);
    }
}
