using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirchhoff_Libary.Data_Stuff;

internal class Calculating_Meshes_and_Junctions
{
    /*  
     *  Calculating the Currents at each Resistor using Dependencies
     *  Needs: current_Mesh array
     *  Declares: a array "currents_array" of length Resistors
     *  
     *  calculating the Voltages at each Resistor using Ohm_Law
     *  Needs: currents_array, resitor_array
     *  Declares: a array "voltages_array" of lemgth Resistors
     */

    internal int amtResistor;
    internal double[] CurrentMeshes;
    internal double[] CurrentAtResistor;
    internal double[] ResistorArray;
    internal double currentAtSource;
    internal DataGathering data;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="currentMeshes"></param>
    /// <param name="resistorArray"></param>
    /// <param name="compValuesResistor"></param>
    public Calculating_Meshes_and_Junctions(double[] currentMeshes, double[] resistorArray, double[] compValuesResistor)
    {
        DataGathering data = new DataGathering(resistorArray, currentMeshes, compValuesResistor);
        CurrentMeshes = data.CurrentMeshes;
        ResistorArray = data.ResistorArray;
        amtResistor = data.ResistorArray.Length;
        CurrentAtResistor = CalcCurrentAtResistor();
    }

    /// <summary>
    /// Calculates the Currents at each Resistor
    /// ! MODIFY ! -> automate / modularity
    /// </summary>
    /// <param name="amtResistor"></param>
    /// <returns></returns>
    private double[] CalcCurrentAtResistor()
    {
        double[] currentArrayAtResistor = new double[amtResistor];

        // Manually set each Value to the Corresponding index
        currentArrayAtResistor[0] = CurrentMeshes[0];
        currentArrayAtResistor[1] = CurrentMeshes[0] + CurrentMeshes[1];
        currentArrayAtResistor[2] = CurrentMeshes[0] - CurrentMeshes[2];
        currentArrayAtResistor[3] = CurrentMeshes[1] + CurrentMeshes[2];
        currentArrayAtResistor[4] = - CurrentMeshes[1];
        currentArrayAtResistor[5] = CurrentMeshes[2];

        return currentArrayAtResistor;

    }

    /// <summary>
    /// Calculating the Current at the Source
    /// </summary>
    /// <returns></returns>
    private double CalcCurrentAtSource()
    {
        return currentAtSource = CurrentMeshes[0];
    }
}
