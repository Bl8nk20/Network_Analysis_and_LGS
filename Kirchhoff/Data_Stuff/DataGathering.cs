using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.Data_Stuff
{
    /*
     * Needed: Array of Resistors
     *         Array of Current Meshes
     *         Array of the Build-In Components
     */
    internal class DataGathering
    {
        /// <summary>
        /// the array of the calculated mesh contents
        /// </summary>
        internal double[] _resistorArray;
        public double[] ResistorArray
        {
            get
            {
                return _resistorArray;
            }
            set
            {
                _resistorArray = value;
            }
        }

        /// <summary>
        /// the currents in each mesh
        /// </summary>
        internal double[] _currentMeshes;
        public double[] CurrentMeshes
        {
            get
            {
                return _currentMeshes;
            }
            set
            {
                _currentMeshes = value;
            }
        }

        /// <summary>
        /// the array of the Resistor Component Values
        /// </summary>
        internal double[] compValueResistor;
        public double[] CompValueResistor
        {
            get
            {
                return compValueResistor;
            }
            set
            {
                compValueResistor = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resistorArray"></param>
        /// <param name="currentMeshes"></param>
        /// <param name="componentsResistors"></param>
        public DataGathering(double[] resistorArray, double[] currentMeshes, double[] componentsResistors)
        {
            ResistorArray = resistorArray;
            CurrentMeshes = currentMeshes;
            CompValueResistor = componentsResistors;
        }
    }

}
