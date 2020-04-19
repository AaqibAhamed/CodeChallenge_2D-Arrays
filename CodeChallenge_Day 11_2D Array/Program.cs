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

            for(int i=0;i<6;i++)
            {
                myArr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
           
            Console.ReadLine();

        }
    }
}
