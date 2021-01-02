using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerHankExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // fazer chamadas dos métodos abaixo para testes...
        }

        // https://www.hackerrank.com/challenges/simple-array-sum/problem
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int diagonal1Sum = 0;
            int diagonal2Sum = 0;
            for(int i = 0, j = arr.Count()-1; i < arr.Count(); i++, j--)
            {
                diagonal1Sum += arr[i][i];
                diagonal2Sum += arr[i][j];
            }
            return Math.Abs(diagonal1Sum - diagonal2Sum);
        }
    }
}
