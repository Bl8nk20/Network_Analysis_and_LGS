namespace LES_Solving;

public class GaussianElimination : IDataManipulator<double[]>
{
    private readonly int _numRows;
    private readonly int _numCols;
    private readonly double[,] _aMatrix;

    public GaussianElimination(double[] arrayForMatrix)
    {
        DataProvider dataProvider = new DataProvider(arrayForMatrix);
        _numRows = dataProvider.num_of_Rows();
        _numCols = dataProvider.num_of_Cols();
        _aMatrix = modify_matrix(dataProvider.getting_matrix_from_Vector());
    }

    // adding a new Row to the matrix
    private double[,] modify_matrix(double[,] startMatrix)
    {
        // WIP
        return _aMatrix;
    }
    
    // performing the gaussian elimination method and get the stair setup
    public void Gauss_Elimination()
    {
        for (int i = 0; i < _numRows - 1; i++)
        {
            for (int j = i + 1; j < _numRows; j++)
            {
                double factor = _aMatrix[j, i] / _aMatrix[i, i];
                for (int k = i; k < _numCols; k++)
                { 
                    _aMatrix[j, k] -= factor * _aMatrix[i, k];
                }
            }
        }
    }

    // Calculating the Result using the Back Substitution
    public double[] Calculating_Result()
    {
        double[] xVector = new double[_numRows];

        for (int i = _numRows - 1; i >= 0; i--)
        {
            double sum = 0.0;
            for (int j = i + 1; j < _numRows; j++)
            {
                sum += _aMatrix[i, j] * xVector[j];
            }
            xVector[i] = (_aMatrix[i, _numCols - 1] - sum) / _aMatrix[i, i];
        }
        
        return xVector;
    }
}
