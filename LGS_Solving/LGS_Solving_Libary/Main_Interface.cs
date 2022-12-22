using LGS_Solving_Libary.Data_Stuff;

namespace LGS_Solving_Libary;

/// <summary>
/// A class for the main Interface of the Libary
/// </summary>
public class Main_Interface
{
    // initializing fields
    private readonly Interfaces.IDataProvider _dataProvider;
    private readonly Interfaces.IManipulator _manipulator;

    /// <summary>
    /// Constructor for the main Logic
    /// </summary>
    /// <param name="dataProvider">-> Data Gathering -> setting everything up</param>
    /// <param name="manipulator">-> Data Manipulation -> calculations</param>
    public Main_Interface(Interfaces.IDataProvider dataProvider, Interfaces.IManipulator manipulator)
    {
        _dataProvider = dataProvider;
        _manipulator = manipulator;
    }

    /// <summary>
    /// Basic Logic for the Libary
    /// </summary>
    public double[] Process()
    {
        double[] calculations_done = _manipulator.calculating();

        return calculations_done;
    }
}