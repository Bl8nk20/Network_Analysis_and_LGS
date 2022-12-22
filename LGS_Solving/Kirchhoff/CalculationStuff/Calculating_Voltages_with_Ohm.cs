using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.CalculationStuff;

public class Calculating_Voltages_with_Ohm
{
    // Initializing fields
    private readonly double _Uq1;
    private readonly double[] _resistor_array;
    private readonly double[] _current_array;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Uq1"></param>
    /// <param name="resistor_array"></param>
    /// <param name="current_array"></param>
    public Calculating_Voltages_with_Ohm(double Uq1, double[] resistor_array, double[] current_array)
    {
        _Uq1 = Uq1;
        _resistor_array = resistor_array;
        _current_array = current_array;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double[] Calculating_Voltages()
    {
        //
        double[] voltages_array = new double[_resistor_array.Length + 1];
        //
        for (int i = 0; i < _current_array.Length; i++)
        {
            //
            if (i == 0)
            {
                voltages_array[i] = _Uq1;
            }
            else
            {
                voltages_array[i] = Math.Round(_current_array[i] * _resistor_array[i], 3);
            }
        }
        return voltages_array;
    }
}
