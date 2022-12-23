using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking_analysis.Gui_Data
{
    internal class Meshes_in_Resistor
    {
        private readonly double[] _currents_Meshes;

        public Meshes_in_Resistor()
        {
            Logic_Calling_WPF calling_WPF = new Logic_Calling_WPF();
            User_Inputs user_Inputs = new User_Inputs();
            _currents_Meshes = calling_WPF.Current_Meshes();
        }

        public double[] Currents_at_resistor()
        {
            double[] currents_at_resistor =
            {
                _currents_Meshes[0],
                _currents_Meshes[0],
                _currents_Meshes[0] + _currents_Meshes[1],
                _currents_Meshes[1] - _currents_Meshes[2],
                _currents_Meshes[1] + _currents_Meshes[2],
                _currents_Meshes[1],
                _currents_Meshes[2],
            };
            return currents_at_resistor;
        }
    }
}
