using System;
using System.Linq;
using System.Windows.Forms;

namespace Simplex_Algorithm
{
    public partial class SimplexAlgorithm : Form
    {
        public SimplexAlgorithm()
        {
            InitializeComponent();
            AlgorithmBox.DataSource = GlobalContext.Strategies.ToList();
            AlgorithmBox.SelectedItem = string.Empty;            
        }
        private void AlgorithmBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Controller.StrategyChanged(AlgorithmBox.SelectedItem.ToString());
        }

        private void ColBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Controller.ChangeCols(ColBox.SelectedItem.ToString(), MatrixView);
        }

        private void RowsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Controller.ChangeRows(RowsBox.SelectedItem.ToString(), MatrixView);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Controller.Clear(MatrixView, ResultText);
        }

        private void SolveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var answer = Controller.Solve(MatrixView);
                ResultText.Text = "x* = (";
                foreach (var number in answer)
                {
                    ResultText.Text += (string.Format("{0:0.000}", number)+" ");

                }
                ResultText.Text += ")";      
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }
    }
}
