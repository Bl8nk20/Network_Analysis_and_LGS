namespace LGS_Solving_Libary;

/// <summary>
/// A class for the main Interface of the Libary
/// </summary>
public class Main_Interface
{
    // initializing fields
    private readonly IDataProvider<double> _dataProvider;
    private readonly IManipulator<double, double> _manipulator;

    /// <summary>
    /// Constructor for the main Logic
    /// </summary>
    /// <param name="dataProvider">-> Data Gathering -> setting everything up</param>
    /// <param name="manipulator">-> Data Manipulation -> calculations</param>
    public Main_Interface(IDataProvider<double> dataProvider, IManipulator<double, double> manipulator)
    {
        _dataProvider = dataProvider;
        _manipulator = manipulator;
    }

    /// <summary>
    /// Basic Logic for the Libary
    /// </summary>
    public void Process()
    {

    }
}