using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BubbleSortPerf
{
    public class Tester
    {

        private static int[] _mediumCaseVector;
        private static int[] _worstCaseVector;
        private static int[] _bestCaseVector;

        private static void _GenerateVectors()
        {
            Random rng = new Random();
            
            Tester._worstCaseVector = new int[10000];
            Tester._mediumCaseVector = new int[10000];
            Tester._bestCaseVector = new int[10000];
            
            for (int i = 0; i < 10000; i++)
            {
                _mediumCaseVector[i] = rng.Next();
                _bestCaseVector[i] = i;
                _worstCaseVector[i] = 10000 - i;
            }
        }

        public class Results
        {
            public TimeSpan[] WorstCase, AverageCase, BestCase;
        }

        public Results[] Test()
        {
            _GenerateVectors();
            
            return new Results[2];
        }

        public int[] Cut(int[] array, int size)
        {
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = array[i];
            }

            return res;
        }
    }
}