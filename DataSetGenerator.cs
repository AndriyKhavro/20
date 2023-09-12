using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBenchmark;

internal static class DataSetGenerator
{
    public static int[] Generate(int min, int max, int size)
    {
        var result = new int[size];
        var random = new Random();

        for(int i = 0; i < size; i++)
        {
            result[i] = random.Next(min, max);
        }

        return result;
    }
}