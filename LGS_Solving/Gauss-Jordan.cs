using LES_Solving;

namespace Gauss_Jordan;

public class GaussJordan : IDataManipulator<double[]>
{
    private readonly int _numRows;
    private readonly int _numCols;
    private readonly double[] _array_for_matrix;
    private readonly double[,] _matrix;

    public GaussJordan(double[] array_for_matrix)
    {
        _array_for_matrix = array_for_matrix;
        DataProvider dataProvider = new DataProvider(_array_for_matrix);
        _numRows = dataProvider.num_of_Rows();
        _numCols = dataProvider.num_of_Cols();
        _matrix = dataProvider.getting_matrix_from_Vector();
    }
    
    // Method for calculating the LES using Gauss-Jordan method
    public double[] Calculating_Result()
    {
        double[] xVector = new double[_numRows];

        for (int row = 0; row < _numRows + 1; row++)
        {
            if (_matrix[row, row] == 0)
            {
                throw new Exception("Mathematical Error!");
            }
            for(int col = 0; col < _numCols; col++)
            {
                if (col == row)
                {
                    continue;
                }
                double Ratio = _matrix[col, row] / _matrix[row, row];
                for (int i = 0; i < _numCols + 1; i++)
                {
                    _matrix[col, i] -= Ratio * _matrix[row, i];
                }
            }
        }

        for (int i = 0; i < xVector.Length; i++)
        {
            xVector[i] = _matrix[i, xVector.Length + 1] / _matrix[i, i];
        }
        
        return xVector;
    }
}