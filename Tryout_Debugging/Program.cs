using System;
using System.Reflection.Metadata.Ecma335;
using Kirchhoff_Libary.Data_Stuff;
using Kirchhoff_Libary;
using Data_Read_and_Write.Data_Stuff;
using LGS_Solving_Libary.Data_Stuff;

/// <summary>
/// Debugging / Testing Class -> Predefined Values Collections :D
/// </summary>
class Debugging
{
    public double[] Uq1
    {
        get { return VoltageArray(); }
    }
    public double[] ResistorArray
    {
        get { return ResistorArrayGenerating(); }
    }

    public double[] Resistors
    {
        get { return resistors(); }
    }

    public double[] volts
    {
        get { return Volti(); }
    }

    public double[] currents
    {
        get { return Currents(); }
    }


    /// <summary>
    /// Pre defined Values for the Matrix Generation
    /// </summary>
    /// <returns></returns>
    private double[] ResistorArrayGenerating()
    {
        double[] resistorArray = new double[9];
        resistorArray[0] = 15;
        resistorArray[1] = 5;
        resistorArray[2] = -5;
        resistorArray[3] = 5;
        resistorArray[4] = 20;
        resistorArray[5] = 10;
        resistorArray[6] = -5;
        resistorArray[7] = 10;
        resistorArray[8] = 20;
        return resistorArray;
    }


    /// <summary>
    /// Pre defined Values for the Source Voltage / bVector
    /// </summary>
    /// <returns></returns>
    private double[] VoltageArray()
    {
        double[] Voltages = new double[3];
        Voltages[0] = 12;
        Voltages[1] = 0;
        Voltages[2] = 0;
        return Voltages;
    }


    /// <summary>
    /// Pre defined Values for the Predefined Resistors
    /// </summary>
    /// <returns></returns>
    private double[] resistors()
    {
        double[] resis = new double[6];
        resis[0] = 5;
        resis[1] = 5;
        resis[2] = 5;
        resis[3] = 10;
        resis[4] = 5;
        resis[5] = 5;

        return resis;
    }

    /// <summary>
    /// Pre defined Values for the Calculated Volts
    /// </summary>
    /// <returns></returns>
    private double[] Volti()
    {
        double[] volti = new double[6];
        volti[0] = 6;
        volti[1] = 3;
        volti[2] = 3;
        volti[3] = 0;
        volti[4] = 3;
        volti[5] = 3;

        return volti;

    }

    /// <summary>
    /// Pre defined Values for the Calculated Currents
    /// </summary>
    /// <returns></returns>
    private double[] Currents()
    {
        double[] currs = new double[6];

        currs[0] = 1.2;
        currs[1] = 0.6;
        currs[2] = 0.6;
        currs[3] = 0;
        currs[4] = 0.6;
        currs[5] = 0.6;

        return currs;

    }

}
/// <summary>
/// Main Interaction Logic for the Program
/// </summary>
class Process
{

    public void calculating()
    {
        // Calling Debugging class
        Debugging debugging = new Debugging();
        // Writing file

        // Testing for gaussian Elimination
        Gaussian_Elimination gaussianElimination = new Gaussian_Elimination(debugging.ResistorArray, debugging.Uq1);
        double[] result = gaussianElimination.CalculatingResult();

        foreach (double v in result)
        {
            Console.WriteLine(v);
        }

        // Testing for Determinant Calculation
        //Determinant_Gauss _Gauss = new Determinant_Gauss(debugging.ResistorArray, debugging.Uq1);
        //double det = _Gauss.CalculatingDet(_Gauss._matrix);
        //Console.WriteLine(det);

        // Testing First Kirchhoff Law & Second Kirchhoff
        Kirchhoff_Process kirchhoff = new Kirchhoff_Process();
        Ohm_Law ohm_Law = new Ohm_Law();
        kirchhoff.process(debugging.ResistorArray, result, debugging.Resistors, debugging.Uq1[0]);

        // Testing if the Results are written in the csv file
        Writing writingFile = new Writing(ohm_Law.voltages, debugging.Resistors, debugging.currents);
        writingFile.WritingFile();

        // Testing if the File is read

    }

}

public class Program 
{ 

    static void Main(string[] args)
    {
        // Main Logic
        Process process = new Process();
        process.calculating();
    }

}