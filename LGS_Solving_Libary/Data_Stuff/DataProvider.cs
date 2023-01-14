using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.Data_Stuff;

/// <summary>
/// a Class to Collect every Data needed to solve a LES
/// </summary>
public class DataProvider : Interfaces.IDataGathering<double[,]>
{
    // Initializing Fields
    private readonly int _numRows;
    private readonly int _numCols;
    public double[] _array_for_matrix_gen { get; set; }
    public double[] _bVector { get; set; }
    public double[,] _aMatrix { get; set; }

    /// <summary>
    /// Constructor for the DataProvider Class, to collects the Data and creates a Matrix, calculates the Number of Rows and Columns and adjust the Matrix when needed
    /// </summary>
    /// <param name="array_for_matrix"></param>
    public DataProvider(double[] array_for_matrix, double[] bVector)
    {
        _array_for_matrix_gen = array_for_matrix;
        _bVector = bVector;
        _numRows = num_of_Rows();
        _numCols = num_of_Cols();        
    }

    /// <summary>
    /// a Method that calculates the number of rows, using the square root of the Length of the Array
    /// </summary>
    /// <returns></returns>
    public int num_of_Rows()
    {
        int numRows = (int)Math.Sqrt(_array_for_matrix_gen.Length);
        return numRows;
    }

    /// <summary>
    /// a method that checks if the matric is perfectly square
    /// </summary>
    /// <returns>true, if the Matrix is perfectly square</returns>
    private bool IsPerfectSquare()
    {
        double sqrt = Math.Sqrt(_numRows);
        return sqrt == (int)sqrt;
    }

    /// <summary>
    /// a Method to calculate the Number of Columns if the Matrix isnt perfectly square
    /// </summary>
    /// <returns></returns>
    public int num_of_Cols()
    {
        int cols = _numRows;

        if (!IsPerfectSquare())
        {
            cols = _array_for_matrix_gen.Length / _numRows;
        }

        return cols;
    }

    /// <summary>
    /// method for collecting the data in a 2d array / matrix
    /// </summary>
    /// <returns>-> a 2d array / matrix</returns>
    public double[,] A_Matrix_Creating()
    {
        double[,] _aMatrix = new double[_numRows, _numCols];
        int index = 0;
        // Populate the matrix with values from the array
        for (int i = 0; i < _numRows; i++)
        {
            for (int j = 0; j < _numCols; j++)
            {
                _aMatrix[i, j] = _array_for_matrix_gen[index];
                index++;
            }
        }
        return _aMatrix;
    }
}
