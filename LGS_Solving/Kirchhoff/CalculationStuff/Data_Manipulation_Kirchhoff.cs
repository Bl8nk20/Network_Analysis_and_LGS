using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kirchhoff_Libary.CalculationStuff;

namespace Kirchhoff_Libary.CalculationStuff;

public class Data_Manipulation_Kirchhoff
{
    private readonly double[] _resistances_array;
    private readonly double[] _currents_array;
    private readonly double[] _voltages_array;
    private readonly double _Uq1;

    public Data_Manipulation_Kirchhoff(double Uq1,  double[] resistances, double[] currents_array)
    {
        _resistances_array = resistances;
        _currents_array = currents_array;
        _Uq1 = Uq1;
        _voltages_array = voltages_at_resistor();
    }

    public double[] voltages_at_resistor()
    {
        Calculating_Voltages_with_Ohm ohm_Law = new Calculating_Voltages_with_Ohm(_Uq1,_resistances_array, _currents_array);

        return ohm_Law.Calculating_Voltages();
    }
}