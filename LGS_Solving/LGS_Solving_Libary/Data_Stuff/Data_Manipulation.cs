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
    private readonly double[,] _A_Matrix;
    private readonly double[] _b_vector;

    /// <summary>
    /// Constructor for the Manipulation / Calculation Step in Form of A*x0b -> (A|b)
    /// </summary>
    /// <param name="A_Matrix"> Matrix_generated from array in Gathering Step</param>
    /// <param name="B_Vector"></param>
    public Data_Manipulation(double[] b_vector, double[] A_vector_for_Matrix_gen)
    {
        Data_Gathering data_Providing = new Data_Gathering(A_vector_for_Matrix_gen, b_vector);
        _A_Matrix = data_Providing.A_Matrix_Creating();
        _b_vector = b_vector;
    }

    /// <summary>
    /// A Method for Calculating the x_Vector using LES and Back Substitution
    /// </summary>
    /// <returns>an array of Values</returns>
    public double[] calculating()
    {

        // calling gauß and the Back_Substitution method - Hoping that the Matrix is recognized
        LGS_Gauß gaussian = new LGS_Gauß(_b_vector, _A_Matrix);
        return gaussian.Back_Substitution_for_vector_x();
    }
}
