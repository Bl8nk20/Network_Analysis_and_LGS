using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.Data_Stuff;

/// <summary>
/// a Class to Collect every data needed / Resistances & Voltages
/// </summary>
public class Data_Gathering : Interfaces.IDataProvider
{
    // Initializing Fields
    private readonly int _num_of_rows;
    private readonly int _num_of_cols;
    private readonly double[,] _A_Matrix_Values;
    private readonly double[] _creating_from_Matrix_array;

    /// <summary>
    /// a constructor to calculate / set the arrays / Vectors / Matrix
    /// </summary>
    /// <param name="creating_from_Matrix_array"
    /// <param name="num_of_cols"></param>
    /// <param name="num_of_rows"></param>
    public Data_Gathering(double[] creating_from_Matrix_array)
    {
        _creating_from_Matrix_array = creating_from_Matrix_array;
        // ! Assuming Array is perfectly square !
        _num_of_rows = (int)Math.Sqrt(_creating_from_Matrix_array.Length);
        _num_of_cols = _creating_from_Matrix_array.Length / _num_of_rows;
        _A_Matrix_Values = A_Matrix_Creating();
    }

    /// <summary>
    /// method for collecting the data in a 2d array / matrix
    /// </summary>
    /// <returns>-> a 2d array / matrix</returns>
    public double[,] A_Matrix_Creating()
    {
        double[,] A_Matrix_Values = new double[_num_of_rows, _num_of_cols];
        try
        {
            // Populate the matrix with values from the array
            for (int i = 0; i < _num_of_rows; i++)
            {
                for (int j = 0; j < _num_of_cols; j++)
                {
                    A_Matrix_Values[i, j] = _creating_from_Matrix_array[i * _num_of_cols + j];
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return A_Matrix_Values;
    }
}
