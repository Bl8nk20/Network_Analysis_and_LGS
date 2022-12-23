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
    private readonly double[] _b_vector_array;

    /// <summary>
    /// a constructor to calculate / set the arrays / Vectors / Matrix
    /// </summary>
    /// <param name="creating_from_Matrix_array"
    /// <param name="num_of_cols"></param>
    /// <param name="num_of_rows"></param>
    public Data_Gathering(double[] creating_from_Matrix_array, double[] b_vector)
    {
        _creating_from_Matrix_array = creating_from_Matrix_array;
        _b_vector_array = b_vector;
        // ! Assuming Array is perfectly square !
        _num_of_rows = (int)Math.Sqrt(_creating_from_Matrix_array.Length);
        _num_of_cols = _num_of_rows + 1;
        _A_Matrix_Values = A_Matrix_Creating();
    }

    /// <summary>
    /// method for collecting the data in a 2d array / matrix
    /// </summary>
    /// <returns>-> a 2d array / matrix</returns>
    public double[,] A_Matrix_Creating()
    {
        double[,] A_Matrix_Values = new double[_num_of_rows, _num_of_cols];
        int index = 0;
        // Populate the matrix with values from the array
        for (int i = 0; i < _num_of_rows; i++)
        {
            for (int j = 0; j < _num_of_cols; j++)
            {
                // skipping for the last col to populate it later
                if (j == _num_of_cols - 1)
                {
                    continue;
                }
                A_Matrix_Values[i, j] = _creating_from_Matrix_array[index];
                index++;
            }
        }
        // Population of the last column of the 2D-Array
        for(int j = 0; j < _num_of_rows; j++)
        {
            A_Matrix_Values[j, _num_of_cols - 1] = _b_vector_array[j];
        }
        return A_Matrix_Values;
    }
}
