using System;
using System.Collections.Generic;
using System.Text;

namespace Simplex_Algorithm
{
    internal static class Service
    {
        public static double MultiplyVectors(List<double> vector1, List<double> vector2)
        {
            double result = 0;
            if (vector1.Count != vector2.Count)
                throw new ArgumentException();
            for (int i = 0; i < vector1.Count; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return result;
        }
    }
}
