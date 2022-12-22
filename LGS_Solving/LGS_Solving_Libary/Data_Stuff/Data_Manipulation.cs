using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.Data_Stuff;

/// <summary>
/// A class for the Manipulation logic -> class and method calling
/// </summary>
public class Data_Manipulation : Interfaces.IManipulator
{
    // Initializing Fields
    private readonly double[] _A_Matrix_vector;
    private readonly double[,] _A_Matrix;
    private readonly double[] _b_vector;
    private readonly double[] _x_vector;

    /// <summary>
    /// Constructor for the Manipulation / Calculation Step in Form of A*x0b -> (A|b)
    /// </summary>
    /// <param name="A_Matrix"> Matrix_generated from array in Gathering Step</param>
    /// <param name="B_Vector"></param>
    public Data_Manipulation(double[] A_previous_array, double[] B_Vector)
    {
        _A_Matrix_vector = A_previous_array;
        Data_Gathering data_Providing = new Data_Gathering(_A_Matrix_vector);
        _A_Matrix = data_Providing.A_Matrix_Creating();
        _b_vector = B_Vector;
        _x_vector = calculating();

    }

    /// <summary>
    /// A Method for Calculating the x_Vector using LES and Back Substitution
    /// </summary>
    /// <returns>an array of Values</returns>
    public double[] calculating()
    {
        double[] _x_vector = new double[_b_vector.Length];

        // calling gauß and the Back_Substitution method - Hoping that the Matrix is recognized
        LGS_Gauß gaussian = new LGS_Gauß(_b_vector, _A_Matrix);
        gaussian.Back_Substitution_for_vector_x();

        return _x_vector;
    }
}
