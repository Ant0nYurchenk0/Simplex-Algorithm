using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simplex_Algorithm
{
    class Matrix
    {
        internal List<List<double>> Rows { get => rows; }
        internal int RowCount { get => rowCount; }
        internal int ColumnCount { get => columnCount; }

        internal Matrix(DataGridView matrix)
        {
            for (int i = 0; i < matrix.RowCount; i++)
            {
                var matrixRow = new List<double>();
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrixRow.Add(Convert.ToDouble(matrix.Rows[i].Cells[j].Value));
                    columnCount++;
                }
                Rows.Add(matrixRow);
                rowCount++;
            }
            columnCount /= rowCount;
        }
        internal void DeleteRow(int number)
        {
            rows.RemoveAt(number);
            rowCount--;
        }
        internal List<double> GetColumn(int number)
        {
            List<double> result = new List<double>();
            foreach (var row in Rows)
            {
                result.Add(row[number]);
            }
            return result;
        }
        internal List<double> LastRow()
        {
            return this[rowCount-1];
        }
        internal List<double> LastCol()
        {
            return GetColumn(columnCount - 1);
        }
        internal List<double> this[int key]
        {
            get => Rows[key];
            set => Rows[key] = value;
        }  
        private int rowCount = 0;
        private int columnCount = 0;
        private List<List<double>> rows = new List<List<double>>();
    }
}
