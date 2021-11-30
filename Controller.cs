using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simplex_Algorithm
{
    internal static class Controller
    {
        internal static void StrategyChanged(string strategy)
        {
            switch (strategy)
            {
                case "Dual":
                    GlobalContext.Solver.Strategy = new DualAlgorithm();
                    break;
                default:
                    GlobalContext.Solver.Strategy = null;
                    break;
            }
        }
        internal static void ChangeCols(string cols, DataGridView matrix)
        {
            int columns = Convert.ToInt32(cols);
            if (columns > matrix.ColumnCount)
            {
                AddCols(columns, matrix);
            }
            if (columns < matrix.ColumnCount)
            {
                RemoveCols(columns, matrix);
            }
        }
        internal static void ChangeRows(string rowCount, DataGridView matrix)
        {
            int rows = Convert.ToInt32(rowCount);
            if (rows > matrix.RowCount)
            {
                AddRows(rows, matrix);
            }
            if (rows < matrix.RowCount)
            {
                RemoveRows(rows, matrix);
            }
        }
        internal static void Clear (DataGridView matrix, TextBox result)
        {
            matrix.Columns.Clear();
            matrix.Rows.Clear();
            result.Clear();
        }
        internal static List<double> Solve(DataGridView matrix)
        {
            return GlobalContext.Solver.Solve(new Matrix(matrix));
        }
        private static void AddCols(int cols, DataGridView matrix)
        {
            for (int i = matrix.ColumnCount; i < cols; i++)
            {
                var column = new DataGridViewTextBoxColumn();
                column.Width = 50;
                matrix.Columns.Add(column);
            }
            Rename(matrix); 
        }
        private static void AddRows(int rows, DataGridView matrix)
        {
            try
            {
                for (int i = matrix.RowCount; i < rows; i++)
                {
                    var row = new DataGridViewRow();
                    matrix.Rows.Add(row);
                }
                Rename(matrix); 
            }
            catch
            {
                AddCols(1, matrix);
                AddRows(rows, matrix);
            }
        }
        private static void RemoveCols(int cols, DataGridView matrix)
        {
            for (int i = matrix.ColumnCount; i > cols; i--)
            {
                matrix.Columns.Remove(matrix.Columns[i-1]);
            }
            Rename(matrix);
        }
        private static void RemoveRows(int rows, DataGridView matrix)
        {
            for (int i = matrix.RowCount; i > rows; i--)
            {
                matrix.Rows.Remove(matrix.Rows[i-1]);
            }
            Rename(matrix);
        }
        private static void Rename(DataGridView matrix)
        {
            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                matrix.Columns[i].HeaderCell.Value = i != matrix.ColumnCount - 1 ? "x" + (i + 1).ToString() : "result";
            }
            for (int j = 0; j < matrix.RowCount; j++)
            {
                if (j == matrix.RowCount-1)
                    matrix.Rows[j].HeaderCell.Value = "f=";
                else
                    matrix.Rows[j].HeaderCell.Value = string.Empty;
            }
        }
    }
}
