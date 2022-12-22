using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking_analysis.Gui_Data;

internal class Data_Gathering_WPF
{
    public double[] calling_User_inputs_No1()
    {
        double[] resistances = { 15, 5, -5, 5, 20, 10, -5, 10, 20 };
        return resistances;
    }

    public double[] calling_User_inputs_No2()
    {
        double[] Voltages = { 12, 0, 0 };
        return Voltages;
    }
}
