using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking_analysis.Gui_Data;

internal class User_Inputs
{
    public double[] calling_User_inputs_Resistors()
    {
        double[] resistances =
            {
            Convert.ToDouble(R1.Text) + Convert.ToDouble(R2.Text) + Convert.ToDouble(R3.Text),
            Convert.ToDouble(R2.Text),
            - Convert.ToDouble(R3.Text),
            Convert.ToDouble(R2.Text),
            Convert.ToDouble(R2.Text) + Convert.ToDouble(R4.Text) + Convert.ToDouble(R5.Text),
            Convert.ToDouble(R4.Text),
            - Convert.ToDouble(R3.Text),
            Convert.ToDouble(R4.Text),
            Convert.ToDouble(R3.Text) + Convert.ToDouble(R4.Text) + Convert.ToDouble(R6.Text)
        };
        return resistances;
    }

    public double[] calling_User_inputs_Voltages()
    {
        double[] Voltages = { Convert.ToDouble(Uq1.Text), 0, 0 };
        return Voltages;
    }
}
