namespace LES_Solving;

public class GaussianElimination : IDataManipulator<double[]>
{
    private readonly int _numRows;
    private readonly int _numCols;
    private readonly double[] _bVector;
    private readonly double[,] _aMatrix;

    public GaussianElimination(double[] arrayForMatrix)
    {
        DataProvider dataProvider = new DataProvider(arrayForMatrix);
        _numRows = dataProvider.num_of_Rows();
        _numCols = dataProvider.num_of_Cols();
        _aMatrix = modify_matrix(dataProvider.getting_matrix_from_Vector());
    }

    private double[,] modify_matrix(double[,] startMatrix)
    {
        
        return _aMatrix;
    }
    
    public void Gauss_Elimination()
    {
        
    }

    public double[] Calculating_Result()
    {
        double[] xVector;
        return new double[_numRows];
    }
}
