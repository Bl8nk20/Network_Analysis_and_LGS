using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary
{
    public class Data_Gathering
    {
        //
        private readonly string _filename;
        private readonly double _R4x;
        private readonly double _Uq1;
        private readonly double[,] _resistances_matrix;
        private readonly Vector<double> currents;
        private readonly Vector<double> voltages;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="R4x"></param>
        /// <param name="Uq1"></param>
        public Data_Gathering(string filename, double R4x, double Uq1)
        {
            _filename = filename;
            _R4x = R4x;
            _Uq1 = Uq1;
            _resistances_matrix = Resistance_Matrix();
            currents = Calculated_Currents();
            voltages = Source_Voltages();
        }

        /// <summary>
        /// method for collecting the data in a 2d array
        /// </summary>
        /// <returns></returns>
        public double[,] Resistance_Matrix()
        {
            double [,] data = new double[1,1];

            return data;
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Vector<double> Source_Voltages()
        {
            Vector<double> voltages = new Vector<double>();

            return voltages;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Vector<double> Calculated_Currents()
        {
            Vector<double> currents = new Vector<double>();

            return currents;
        }
    }
}
