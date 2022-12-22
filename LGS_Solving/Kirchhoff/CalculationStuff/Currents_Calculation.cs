using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.CalculationStuff;

internal class Currents_Calculation
{
    private readonly double[] _currents_from_meshes;
    private readonly int _resistor_amount;
    
    //
    public Currents_Calculation(double[] currents_from_meshes, int resistors_amount)
    {
        _currents_from_meshes = currents_from_meshes;
        _resistor_amount = resistors_amount;
    }

    //
    public double[] Currents_at_resistors()
    {
        double[] currents_at_resistors = new double[_resistor_amount];

        return currents_at_resistors;
    }
}
