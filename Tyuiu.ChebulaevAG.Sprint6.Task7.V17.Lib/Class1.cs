using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ChebulaevAG.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int cols = line[0].Split(';').Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = line[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j]);
                }
            }
            int row = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (r == 4 && matrix[r, c] < 0)
                    {
                        matrix[r, c] = 9;
                    }
                }
            }
            return matrix;
        }
    }
}
