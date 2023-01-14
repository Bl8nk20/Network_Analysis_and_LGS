using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.InterfacesKirchhoff
{
    internal interface IDataChecking
    {
        /*
         *  A Interface for the first and second Kirchhoff Law
         *  
         *  1. Law:
         *      needs:  array from Currents at Resistors
         *      declares: bool
         *
         *2. Law:
         *      needs: array from Voltage at Resistors
         *      declares: bool
         *  
         */

        bool CheckingBool();
    }
}
