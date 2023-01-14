using Kirchhoff_Libary.InterfacesKirchhoff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.Data_Stuff
{
    internal class Law1 : IDataChecking
    {
        internal double[] currentsAtResistor;
        internal double junction1;
        internal double junction2;
        internal double junction3;
        internal double junction4;

        public double Junction1
        {
            get { return junction1; }
            set { junction1 = currentsAtResistor[0] - currentsAtResistor[5] - currentsAtResistor[1]; }
        }
        public double Junction2
        {
            get { return junction2; }
            set { junction2 = currentsAtResistor[1] - currentsAtResistor[2] - currentsAtResistor[3]; }
        }
        public double Junction3
        {
            get { return junction3; }
            set { junction3 = currentsAtResistor[3] + currentsAtResistor[4] - currentsAtResistor[6]; }
        }
        public double Junction4
        {
            get { return junction4; }
            set { junction4 = currentsAtResistor[2] + currentsAtResistor[5] - currentsAtResistor[0]; }
        }

        public Law1(double[] currentsAtResistor)
        {
            this.currentsAtResistor = currentsAtResistor;
        }

        /// <summary>
        /// A Method that Checks if the first Law of Kirchhoff is True
        /// </summary>
        /// <returns>true if everything is correct.
        /// false if there is an error then returns a exception</returns>
        public bool CheckingBool()
        {
            if((junction1 != 0 || junction2 != 0 || junction3 !=  0 || junction4 != 0))
            {
                return false;
            }
            return true;
        }
    }
}
