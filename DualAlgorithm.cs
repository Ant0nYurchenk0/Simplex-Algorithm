using System;
using System.Collections.Generic;
using System.Linq;

namespace Simplex_Algorithm
{
    class DualAlgorithm : ISimplexAlgorithm
    {
        public List<double> Solve(Matrix problem)
        {
            matrix = problem;
            function = matrix.LastRow();
            basicIndexes = new List<int>();
            matrix.DeleteRow(matrix.RowCount - 1);
            initBasicIndexes();
            checkBasis();
            makePositive();
            bringToDualAlgorithm();
            solveDualAlgorithm();
            return formAnswers();
        }
        private void solveDualAlgorithm()
        {
            List<double> freeCoefs;
            while (checkDeltas(freeCoefs = matrix.LastCol()))
            {
                var deltas = countDeltas();
                int oldBaseIndex = freeCoefs.IndexOf(freeCoefs.Where(d => d < 0).ToList().Min());
                List<double> thetas = new List<double>();
                for (int i = 0; i < matrix.ColumnCount; i++)
                {
                    if (deltas[i] > 0 && matrix[oldBaseIndex][i] > 0)
                        thetas.Add(-matrix.LastCol()[i] / matrix.GetColumn(oldBaseIndex)[i]);
                    else
                        thetas.Add(0);
                }
                int newBaseIndex = thetas.IndexOf(thetas.Where(t => t > 0).ToList().Min());
                basicIndexes[oldBaseIndex] = newBaseIndex;
                recountMatrix(newBaseIndex, oldBaseIndex);
            }
        }
        private void bringToDualAlgorithm()
        {
            List<double> deltas;
            while (checkDeltas(deltas = countDeltas()))
            {
                int newBaseIndex = deltas.IndexOf(deltas.Where(d => d < 0).ToList().Min());
                List<double> thetas = new List<double>();
                for (int i = 0; i < matrix.RowCount; i++)
                {
                    if (matrix.LastCol()[i] > 0 && matrix.GetColumn(newBaseIndex)[i] > 0)
                        thetas.Add(matrix.LastCol()[i] / matrix.GetColumn(newBaseIndex)[i]);
                    else
                        thetas.Add(0);
                }
                int oldBaseIndex = thetas.IndexOf(thetas.Where(t => t > 0).ToList().Min());
                basicIndexes[oldBaseIndex] = newBaseIndex;
                recountMatrix(newBaseIndex, oldBaseIndex);
            }
        }
        private List<double> formAnswers()
        {
            List<double> result = new List<double>();
            for (int i = 0; i < matrix.ColumnCount - 1; i++)
            {
                if (basicIndexes.Contains(i))
                    for (int j = 0; j < matrix.RowCount; j++)
                    {
                        var column = matrix.GetColumn(i);
                        if(column[j] == 1)
                            result.Add(matrix.LastCol()[column.IndexOf(1)]);
                    }
                else
                    result.Add(0);
            }
            return result;
        }
        private void recountMatrix(int newIn, int oldIn)
        {
            for (int i = 0; i < matrix.RowCount; i++)
            {
                if (i != oldIn) 
                {
                    double coef = matrix[i][newIn] / matrix[oldIn][newIn];
                    for (int j = 0; j < matrix.ColumnCount; j++)
                        matrix[i][j] -= matrix[oldIn][j] * coef;
                }
                else
                {
                    double coef = matrix[oldIn][newIn];
                    for (int j = 0; j < matrix.ColumnCount; j++)
                        matrix[i][j] /= coef;
                }

            }
        }
        private List<double> countDeltas()
        {
            var result = new List<double>();
            for (var i = 0; i < matrix.ColumnCount-1; i++)
            {
                List<double> baseCoef = new List<double>();
                foreach (var index in basicIndexes)
                    baseCoef.Add(function[index]);
                result.Add(function[i] - Service.MultiplyVectors(matrix.GetColumn(i), baseCoef));
            }
            return result;
        }
        private bool checkDeltas(List<double> deltas)
        {
            foreach (var item in deltas)
            {
                if (item < 0)
                    return true;
            }
            return false;
        }
        private void initBasicIndexes()
        {
            for (int i = matrix.RowCount; i > 0; i--)
            {
                basicIndexes.Add(matrix.ColumnCount - i - 1);
            }
            basicIndexes.OrderBy(index => index);
        }
        private void checkBasis()
        {
            foreach (var num in basicIndexes)
            {
                int zeroCounter = 0;
                var column = matrix.GetColumn(num);
                foreach (var col in column)
                    if (col == 0) zeroCounter++;
                if (!(zeroCounter == matrix.RowCount - 1
                    && Math.Abs(column[basicIndexes.IndexOf(num)]) == 1))
                {
                    throw new Exception();                
                }
            }
        }
        private void makePositive()
        {
            foreach (var num in basicIndexes)
            {
                if (matrix.GetColumn(num)[basicIndexes.IndexOf(num)] == -1)
                {
                    for (int i = 0; i < matrix.ColumnCount; i++)
                        matrix[basicIndexes.IndexOf(num)][i] *= -1;
                }
            }
        }
        private List<int> basicIndexes;        
        private Matrix matrix;
        private List<double> function;
    }
}
