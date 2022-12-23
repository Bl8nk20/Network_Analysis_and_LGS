using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Networking_analysis.Gui_Data;

internal class Data_Gathering_WPF
{
    User_Inputs User_Inputs = new User_Inputs();
    
    public double[] resistances_array
    {
        get { return User_Inputs.calling_User_inputs_Resistors(); }
    }
    public double[] voltages_array
    {
        get { return User_Inputs.calling_User_inputs_Voltages(); }
    }
}
 