using Kirchhoff_Libary.Data_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kirchhoff_Libary;

public class Kirchhoff_Process
{
    // Modularity NEEDED !!!

    /*
     * 1. Step is calculating the Currents at each resistor -> using the connection between the Meshes and the Resistors -> ?? how to automate / modularity ?? (done manually)
     * 2. Step is checking if the first Kirchhoff Law is true -> Currents at each Resistor -> ?? how to automate / modularity ?? (done)
     * 3. Step if True 
     * 4.    -> Calculate the Voltages using Ohms_Law -> U = R*I -> ! use Ohm Class ! (done)
     * 5. Step Checking if the second Kirchhoff Law is true -> Voltages at each Resistor -> "" how to automate / modularity ?? (done manually)
     * 6. Step if True
     * 6.5.  ->  maybe Calculate Complete Resistor Value of hole Network
     * 7.    -> Return Resistor Values, Voltage Values and Current Values
     * 8. Be happy
     * 
     * Values / Properties needed:
     *      ResistorArray with each Resistor Value
     *      Mesh_Currents_array with the Calculated Currents in each mesh
     */
   
    private double[] voltages;
    public double[] Voltages
    {
        get { return voltages; }
        set { Ohm_Law ohm_Law = new Ohm_Law();
                ohm_Law.VoltageCalc();}
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="resistorArray"></param>
    /// <param name="currentMeshes"></param>
    /// <param name="compResistors"></param>
    /// <param name="sourceVoltage"></param>
    /// <exception cref="Exception"></exception>
    public void process(double[] resistorArray, double[] currentMeshes, double[] compResistors, double sourceVoltage)
    {
        DataGathering data = new DataGathering(resistorArray, currentMeshes, compResistors);
        Calculating_Meshes_and_Junctions calcJuncAndMesh = new Calculating_Meshes_and_Junctions(data._currentMeshes, data.ResistorArray, data.compValueResistor);

        // Checking if the first Law is correct if not throw Exception
        Law1 KH_Law1 = new Law1(calcJuncAndMesh.CurrentAtResistor);
        if (!KH_Law1.CheckingBool())
        {
            throw new Exception("Dumbass! Junctions are Wrong!");
        }

        // Calculating the Voltages at each Resistor
        Ohm_Law ohmLaw = new Ohm_Law();
        Voltages = new double[data.compValueResistor.Length]; 
        for(int i = 0; i < voltages.Length; i++)
        {
            Voltages[i] = ohmLaw.VoltageCalc(data.compValueResistor[i], calcJuncAndMesh.CurrentAtResistor[i]);
        }
        Law_2 KH_Law2 = new Law_2(sourceVoltage,Voltages);
        if (!KH_Law2.CheckingBool())
        {
            throw new Exception("Dumbass! Meshes are Wrong!");
        }


        // Debug
        Console.WriteLine("Passt !");
    }

}
