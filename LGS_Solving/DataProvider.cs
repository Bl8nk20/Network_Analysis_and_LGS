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
        return (int)Math.Sqrt(_array_for_matrix_gen.Length);
    }

    bool IsPerfectSquare()
    {
        double sqrt = Math.Sqrt(_numRows);
        return sqrt == (int)sqrt;
    }
    
    public int num_of_Cols()
    {
        int cols = _numRows;
        
        if (!IsPerfectSquare())
        {
            cols = _array_for_matrix_gen.Length / _numRows;
        }

        return cols;
    }
    
    public double[,] getting_matrix_from_Vector()
    {
        double[,] matrix = new double[_numRows, _numCols];
        int index = 0;
        for (int i = 0; i < _numRows + 1; i++)
        {
            for (int j = 0; j < _numCols + 1; j++)
            {
                matrix[i, j] = _array_for_matrix_gen[index];
                index++;
            }
        }
        return new double[_numRows,_numCols];
    }
}