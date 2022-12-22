using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGS_Solving_Libary.Interfaces
{
    public interface ISolving_Gauss
    {
        double[,] Gaussian_Elimination_Matrix(double[,] matrix);
        double[] Back_Substitution_for_vector_x();
    }
}
