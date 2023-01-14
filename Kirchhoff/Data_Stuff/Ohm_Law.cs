using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.Data_Stuff
{
    public class Ohm_Law
    {
        private double _resistor;
        private double _voltage;
        private double _current;
        private double[] _resistors;
        private double[] _voltages;
        private double[] _currents;

        public double resistor 
        {
            get
            {
                return _resistor;
            }
            set
            {
                _resistor = value;
            }
        }
        public double voltage 
        {
            get
            {
                return _voltage;
            }
            set
            {
                _voltage = value;
            }
        }
        public double current 
        {
            get
            {
                return _current;
            }
            set 
            {
                _current = value;
            }
        }
        public double[] resistors
        {
            get
            {
                return _resistors;
            }
            set
            {
                _resistors = value;
            }
        }
        public double[] voltages
        {
            get
            {
                return _voltages;
            }
            set
            {
                _voltages = value;
            }
        }
        public double[] currents
        {
            get
            {
                return _currents;
            }
            set
            {
                _currents = value;
            }
        }

        // Calculating the Voltage using U = R*I
        // Calculating the Current using I = U/R
        // Calculating the Resistor using R = U/I

        /// <summary>
        /// The Calculation of the Voltage using Ohm´s Law: U = R * I
        /// </summary>
        /// <param name="_resistor">Resistor component value in Ω</param>
        /// <param name="_current"> Current at the Resistor in A</param>
        /// <returns>Voltage in V</returns>
        public double VoltageCalc(double resistor, double current)
        {
            return voltage = resistor * current;
        }

        /// <summary>
        /// The Calculation of the Current using Ohm´s Law: I = U / R
        /// </summary>
        /// <param name="_resistor">Resistor component value in Ω</param>
        /// <param name="_voltage">Voltage at the Resistor in V</param>
        /// <returns>Current in A</returns>
        public double CurrentCalc(double resistor, double voltage)
        {
            return current = voltage / resistor;
        }

        /// <summary>
        /// The Calculation of the Resistor using Ohm´s Law: R = U / I
        /// </summary>
        /// <param name="_voltage">Voltage at the Resistor in V</param>
        /// <param name="_current">Current at the Resistor in A</param>
        /// <returns>Resistor component value in Ω</returns>
        public double ResistorCalc(double voltage, double current)
        {
            return resistor = voltage / current;
        }
    }
}
