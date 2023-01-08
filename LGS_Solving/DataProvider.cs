namespace LES_Solving;

public class DataProvider : IDataGathering<double[,]>
{
    private readonly int _numRows;
    private readonly int _numCols;
    private readonly double[] _array_for_matrix_gen;

    public DataProvider(double[] array_for_matrix)
    {
        _numRows = num_of_Rows();
        _numCols = num_of_Cols();
        _array_for_matrix_gen = array_for_matrix;
    }
    
    
    public int num_of_Rows()
    {
        return new int();
    }

    public int num_of_Cols()
    {
        return new int();
    }
    
    public double[,] getting_matrix_from_Vector()
    {
        return new double[_numRows,_numCols];
    }
}