using LGS_Solving_Libary.Data_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kirchhoff_Libary;
using Kirchhoff_Libary.CalculationStuff;

namespace Networking_analysis.Gui_Data;

public class Logic_Calling_WPF
{

    private readonly double[] _resistances_array;
    private readonly double[] _voltages_array;
    private readonly double[] _currents_at_resistor;
    private readonly double _Uq1;
    
    public Logic_Calling_WPF(double Uq1)
    {
        Data_Gathering_WPF Data_Gathering_WPF = new Data_Gathering_WPF();
        Meshes_in_Resistor meshes_In_Resistor = new Meshes_in_Resistor();
        User_Inputs user_Inputs = new User_Inputs();

        _resistances_array = Data_Gathering_WPF.resistances_array;
        _voltages_array = Data_Gathering_WPF.voltages_array;
        _currents_at_resistor = meshes_In_Resistor.Currents_at_resistor();
        _Uq1 = user_Inputs.calling_User_inputs_Voltages()[0];
    }
    
    public double[] Current_Meshes()
    {
        Data_Manipulation manipulating = new Data_Manipulation(_resistances_array, _voltages_array);

        return manipulating.calculating();
    }

    public double[] calculating_voltages_if_right()
    {
        Data_Manipulation_Kirchhoff manipulation_Kirchhoff = new Data_Manipulation_Kirchhoff(_Uq1, _resistances_array, _currents_at_resistor);
        double[] voltages_at_resistor = manipulation_Kirchhoff.voltages_at_resistor();

        Kirchhoff_Laws kirchhoff_Laws = new Kirchhoff_Laws(_currents_at_resistor, voltages_at_resistor);

        if (kirchhoff_Laws.Checking_Meshes() != true || kirchhoff_Laws.Checking_Junctions() != true)
        {
            throw new Exception("Show again on the Calculations");
        }
        else
        {
            return voltages_at_resistor;

        }
    }
}
