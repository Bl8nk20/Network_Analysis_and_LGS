using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary;

/// <summary>
/// A Interface for the Gaussian Elimination Method
/// </summary>
public interface ISolving_Gauss
{
    double[,] Gaussian_Elimination_Matrix(double[,] matrix);
    double[] Back_Substitution_for_vector_x();
}

/// <summary>
/// A Class for the Calculation of the LE
/// </summary>
internal class LGS_Gauß : ISolving_Gauss
{
    // Initializing Fields
    private readonly double[] _vector_b;
    private readonly double[,] _matrix;
    private readonly int _index;
    private readonly double[] _vector_x;

    /// <summary>
    /// a Class to calculate a LE using the Gaussian Elimination Method (A * x = b)
    /// </summary>
    /// <param name="vector_b"> the Vector with the Voltages / "Results"</param>
    /// <param name="matix"> the Matrix with the Resistances / "Frequencys"</param>
    public LGS_Gauß(double[] vector_b, double[,] matix)
    {
        _vector_b = vector_b;
        _matrix = Gaussian_Elimination_Matrix(matix);
        _index = vector_b.Length;
        _vector_x = Back_Substitution_for_vector_x();
    }

    /// <summary>
    /// A method to get the "Stair-Form" in the matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public double[,] Gaussian_Elimination_Matrix(double[,] matrix)
    {
        //
        for (int i = 0; i < _index; i++)
        {
            // Fining Pivot row -> diagonal row
            int pivot = i;
            for (int j = 0; j < _index - 1; j++)
            {
                if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[pivot, i]))
                {
                    pivot = j;
                }
            }
            if (pivot != i)
            {
                for (int j = 0; j < _index; j++)
                {
                    // temporary variable 
                    double temp = matrix[i, j];
                    // little bit of switcherooo
                    matrix[i, j] = matrix[pivot, j];
                    matrix[pivot, j] = temp;
                }
                double temp2 = _vector_b[i];
                _vector_b[pivot] = temp2;
            }
            // Elimate the current variable
            for (int j = i + 1; i < _index; j++)
            {
                // getting the bottom left values to zero
                double factor = matrix[j, i] / matrix[i, i];
                _vector_b[j] -= factor * _vector_b[i];
                for (int k = i; k < _index; k++)
                {
                    matrix[j, k] -= factor * matrix[i, k];
                }
            }
        }
        return matrix;
    }

    /// <summary>
    /// a method to calculate the result ( x -Vector) with back substitution
    /// </summary>
    /// <returns>a vector with calculated current values</returns>
    public double[] Back_Substitution_for_vector_x()
    {
        double[] vector_x = new double[_vector_b.Length];

        // Loop through each variable, starting with the last one 
        for (int i = _index; i >= 0; i--)
        {
            // Sum up the products of the coefficiants and the known variables
            double sum = 0;
            for (int j = i + 1; i < _index; j++)
            {
                sum += _matrix[i, j] * vector_x[j];
            }
            // Solve for the current one
            vector_x[i] = (_vector_b[i] - sum) / _matrix[i, i];
        }

        return vector_x;
    }
}
