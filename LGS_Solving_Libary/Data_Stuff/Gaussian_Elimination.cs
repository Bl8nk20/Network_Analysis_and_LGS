using LGS_Solving_Libary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.Data_Stuff
{
    public class Gaussian_Elimination : IManipulator<double[]>
    {
        public double[,] _aMatrix { get; set; }
        double[] _bVector { get; set; }

        private readonly int n;

        /// <summary>
        /// Constructor to the Gaussian-Elimination Class, which Solves the LES using the Gaussian-ELimination
        /// </summary>
        /// <param name="arrayForMatrix"></param>
        /// <param name="bVector"></param>
        public Gaussian_Elimination(double[] arrayForMatrix, double[] bVector)
        {
            DataProvider dataProvider = new DataProvider(arrayForMatrix, bVector);
            _bVector = bVector;
            _aMatrix = dataProvider.A_Matrix_Creating();
            n = _aMatrix.GetLength(0);
            Gauss();
        }


        /// <summary>
        /// Calculating the Results using Backward-Solving
        /// </summary>
        /// <returns></returns>
        public void Gauss()
        {
            // Gaussian Elimination
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    _aMatrix[i, k] = _aMatrix[i, k] / _aMatrix[k, k];

                    for (int j = k + 1; j < n; j++)
                    {
                        _aMatrix[i, j] = _aMatrix[i, j] - _aMatrix[i, k] * _aMatrix[k, j];
                    }
                }
            }

            // Forward Elimination
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    _bVector[i] = _bVector[i] - _aMatrix[i, k] * _bVector[k];
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double[] CalculatingResult()
        {
            if (_aMatrix[_aMatrix.GetLength(0) - 1,_aMatrix.GetLength(1) - 1] == 0)
            {
                throw new Exception("No Possible Result. Dumbass!");
            }

            double[] xVector = new double[n];
            // Back Substitution
            for(int i = n - 1; i > -1; i--)
            {
                double s = _bVector[i];
                for(int j = i + 1; j < n; j++)
                {
                    s = s - _aMatrix[i, j] * xVector[j];
                }
                //
                xVector[i] = Math.Round( s / _aMatrix[i, i], 6);
            }
            return xVector;
        }
    }
}
