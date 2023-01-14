using LGS_Solving_Libary.InterfacesLES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.Data_Stuff
{
    public class Determinant_Gauss : IDeterminant_Galc<double, double[,]>
    {
        public double[,] _matrix { get; set; }
        public DataProvider data { get; set; }
        public double _det { get; set; }

        private readonly double _test;

        public Determinant_Gauss(double[] array_for_matrix_gen, double[] bVector)
        {
            Gaussian_Elimination gaussian = new Gaussian_Elimination(array_for_matrix_gen, bVector);
            _matrix = gaussian._aMatrix;
            _test = array_for_matrix_gen[0];
            CalculatingDet(_matrix);
        }

        public double CalculatingDet(double[,] matrix)
        {
            _det = 1;

            double[] temp = new double[matrix.GetLength(0)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                temp[i] = matrix[i, i];

            }
            foreach(double x in temp)
            {
                _det *= x;
            }
            return _det;
        }
    }
}
