using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.CalculationStuff;

internal class Kirchhoff_Laws
{
    // Initializing fields
    private readonly double[] _currents_array;
    private readonly double[] _voltages_array;
    private readonly bool _junction_correct;
    private readonly bool _meshes_correct;

    /// <summary>
    /// A Class for the Manipulation logic / Calculation of the Kirchhoff methods
    /// </summary>
    /// <param name="currents_array"> -> an array / Vector of the Currents</param>
    /// <param name="voltages_array"> -> an array / Vector of the Voltages</param>
    public Kirchhoff_Laws(double[] currents_array, double[] voltages_array)
    {
        _currents_array = currents_array;
        _voltages_array = voltages_array;
        _junction_correct = Checking_Junctions();
        _meshes_correct = Checking_Meshes();
    }

    /// <summary>
    /// A Method to check the Junctions, if they add up to zero
    /// </summary>
    /// <returns> true if every junction is zero</returns>
    /// <exception cref="Exception"></exception>
    public bool Checking_Junctions()
    {
        // Predefining very Junction
        double K1 = _currents_array[1] - _currents_array[2] - _currents_array[5];
        double K2 = _currents_array[2] - _currents_array[3] - _currents_array[4];
        double K3 = _currents_array[5] + _currents_array[4] - _currents_array[6];
        double K4 = _currents_array[6] + _currents_array[3] - _currents_array[0];

        // checking zero / bools
        if (K1 != 0 || K2 != 0 || K3 != 0 || K4 != 0)
        {
            return false;
            throw new Exception("System not correct!");
        }
        else
        {
            return true;
        }

    }

    /// <summary>
    /// A Method to check if the Meshes add up to zero
    /// </summary>
    /// <returns> true if every Mesh add up to zero</returns>
    /// <exception cref="Exception"></exception>
    public bool Checking_Meshes()
    {
        // Predefining the Meshes
        double M1 = _voltages_array[1] + _voltages_array[2] + _voltages_array[3] - _voltages_array[0];
        double M2 = _voltages_array[2] + _voltages_array[4] - _voltages_array[5];
        double M3 = _voltages_array[4] + _voltages_array[6] - _voltages_array[3];

        // Checking if the Meshes add up 
        if (M1 != 0 || M2 != 0 || M3 != 0)
        {
            return false;
            throw new Exception("System not correct!");
        }
        else
        {
            return true;
        }
    }
}