using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PetrovNE.Sprint6.Task3.V4.Lib
{
    public class DataService : ISprint6Task3V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; //строки
            int columns = matrix.Length / rows; // столбцы

            for (int i = 0; i < 5; i++)
            {
                if (matrix[1, i] % 2 == 0)
                {
                    matrix[1, i] = 0;
                }
            }
            return matrix;
        }
    }
}
