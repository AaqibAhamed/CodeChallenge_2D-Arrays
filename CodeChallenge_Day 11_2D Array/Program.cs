using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_Day_11_2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArr = new int[6][];
            int[] sum = new int[16];
            int k = 0;

            for (int i = 0; i < 6; i++)
            {
                myArr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum[k] = myArr[i][j] + myArr[i][j + 1] + myArr[i][j + 2] + myArr[i + 1][j + 1] + myArr[i + 2][j] + myArr[i + 2][j + 1] + myArr[i + 2][j + 2];
                    k++;
                }
            }

            Array.Sort(sum);

            Console.WriteLine(sum[15]);


            Console.ReadLine();

        }
    }
}
