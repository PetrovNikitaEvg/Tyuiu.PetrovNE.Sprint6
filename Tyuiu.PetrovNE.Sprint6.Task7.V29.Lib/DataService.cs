using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PetrovNE.Sprint6.Task7.V29.Lib
{
    public class DataService : ISprint6Task7V29
    {
        public int[,] GetMatrix(int[,] matrix)
        {
           int rows = matrix.GetLength(0);
           int cols = matrix.GetLength(1);

            for (int i = 0; i < cols; i++) 
            {
                if (matrix[4, i] >= -5 && matrix[4, i] <= 10)
                {
                    matrix[4, i] = 99;
                }
            }
            return matrix;
        }
    }
}
