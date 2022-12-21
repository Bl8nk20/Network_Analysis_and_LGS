using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary;

/// <summary>
/// An interface, to collect the data from the User_Interface / Input
/// </summary>
public interface IDataProvider<T>
{
    double[,] A_Matrix_Creating();
    double[] B_Vector_Creating();
}

/// <summary>
/// a Class to Collect every data needed / Resistances & Voltages
/// </summary>
public class Data_Gathering : IDataProvider<double>
{
    // Initializing Fields
    private readonly double[] _B_Vector_Values;
    private readonly double[,] A_Matrix_Values;
    private readonly double[] _creating_from_Matrix_array;
    
    /// <summary>
    /// a constructor to calculate / set the arrays / Vectors / Matrix
    /// </summary>
    /// <param name="Uq1"> Source VOltage -> User_Input</param>
    public Data_Gathering(double[] B_Vector_Values, double[] creating_from_Matrix_array)
    {
        _B_Vector_Values = B_Vector_Values;
        _creating_from_Matrix_array = creating_from_Matrix_array;
    }

    /// <summary>
    /// method for collecting the data in a 2d array / matrix
    /// </summary>
    /// <returns>-> a 2d array / matrix</returns>
    public double[,] A_Matrix_Creating()
    {
        _ = _creating_from_Matrix_array;
        double [,] data = new double[3,3];

        return data;
    }       

    /// <summary>
    /// A method to get an array / Vector of the Source Voltages
    /// </summary>
    /// <returns> -> an array of voltages</returns>
    public double[] B_Vector_Creating()
    {
        double[] b_Vector = new double[2];

        return b_Vector;
    }
}
