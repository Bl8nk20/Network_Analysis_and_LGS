using CsvHelper;
using System.Globalization;

namespace Data_Read_and_Write.Data_Stuff;

public class Writing
{
    internal double[] voltages;
    internal double[] resistances;
    internal double[] currents;
    internal int amountResistances;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="voltages"></param>
    /// <param name="resistances"></param>
    /// <param name="currents"></param>
    public Writing(double[] voltages, double[] resistances, double[] currents)
    {
        this.voltages = voltages;
        this.resistances = resistances;
        this.currents = currents;
        amountResistances = resistances.Length;
    }
    public void WritingFile()
    {
        var Collection = new List<DataGathering>();

        for (int i = 0; i < amountResistances; i++)
        {
            Collection.Add(new DataGathering { Voltage = voltages[i], Resistance = resistances[i], Current = currents[i] });
        }

        using (var writer = new StreamWriter("values.csv"))
        using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(Collection);
        }

    }

    ~Writing()
    { }
}
