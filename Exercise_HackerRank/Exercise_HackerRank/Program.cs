using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {          

            List<int> fila1 = new List<int>() { 1, 2, 3 };
            List<int> fila2 = new List<int>() { 4, 5, 6 };
            List<int> fila3 = new List<int>() { 9, 8, 9 };

            List<List<int>> arr = new List<List<int>>();
        }


        public static int diagonalDifference(List<List<int>> arr)
        {
            int Sum1 = 0;
            int Sum2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        Sum1 = Sum1 + arr.ElementAt(i).ElementAt(j);
                    }
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i + j == arr.Count - 1)
                    {
                        Sum2 = Sum2 + arr.ElementAt(j).ElementAt(i);
                    }
                }
            }

            return (Sum1 - Sum2);

        }

    }
}

