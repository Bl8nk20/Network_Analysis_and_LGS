using Kirchhoff_Libary.InterfacesKirchhoff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.Data_Stuff
{
    internal class Law_2 : IDataChecking
    {

        internal double[] voltagesAtResistor;
        internal double sourceVoltage;
        internal double mesh1;
        internal double mesh2;
        internal double mesh3;

        public double Mesh1
        {
            get { return mesh1; }
            set { mesh1 = voltagesAtResistor[0] - voltagesAtResistor[5] - voltagesAtResistor[1]; }
        }
        public double Mesh2
        {
            get { return mesh2; }
            set { mesh2 = voltagesAtResistor[1] - voltagesAtResistor[2] - voltagesAtResistor[3]; }
        }
        public double Mesh3
        {
            get { return mesh3; }
            set { mesh3 = voltagesAtResistor[3] + voltagesAtResistor[4] - voltagesAtResistor[6]; }
        }


        public Law_2(double sourceVoltage, double[] voltagesAtResistor)
        {
            this.voltagesAtResistor = voltagesAtResistor;
            this.sourceVoltage = sourceVoltage;
        }

        /// <summary>
        /// A Method that Checks if the second Law of Kirchhoff is True
        /// </summary>
        /// <returns>true if everything is correct.
        /// false if there is an error then returns a exception</returns>
        public bool CheckingBool()
        {
            if ((mesh1 != 0 || mesh2 != 0 || mesh3 != 0))
            {
                return false;
            }
            return true;
        }

    }
}
