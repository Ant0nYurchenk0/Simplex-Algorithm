
namespace Simplex_Algorithm
{
    partial class SimplexAlgorithm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultText = new System.Windows.Forms.TextBox();
            this.AlgorithmBox = new System.Windows.Forms.ComboBox();
            this.MatrixView = new System.Windows.Forms.DataGridView();
            this.RowsBox = new System.Windows.Forms.ComboBox();
            this.ColBox = new System.Windows.Forms.ComboBox();
            this.ResLabel = new System.Windows.Forms.Label();
            this.AlgLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SolveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixView)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultText
            // 
            this.ResultText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultText.Location = new System.Drawing.Point(68, 396);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(451, 29);
            this.ResultText.TabIndex = 0;
            // 
            // AlgorithmBox
            // 
            this.AlgorithmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlgorithmBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmBox.FormattingEnabled = true;
            this.AlgorithmBox.Location = new System.Drawing.Point(133, 35);
            this.AlgorithmBox.Name = "AlgorithmBox";
            this.AlgorithmBox.Size = new System.Drawing.Size(121, 29);
            this.AlgorithmBox.TabIndex = 1;
            this.AlgorithmBox.SelectedValueChanged += new System.EventHandler(this.AlgorithmBox_SelectedValueChanged);
            // 
            // MatrixView
            // 
            this.MatrixView.AllowUserToAddRows = false;
            this.MatrixView.AllowUserToDeleteRows = false;
            this.MatrixView.BackgroundColor = System.Drawing.Color.Silver;
            this.MatrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixView.Location = new System.Drawing.Point(12, 73);
            this.MatrixView.Name = "MatrixView";
            this.MatrixView.RowTemplate.Height = 25;
            this.MatrixView.Size = new System.Drawing.Size(589, 308);
            this.MatrixView.TabIndex = 2;
            // 
            // RowsBox
            // 
            this.RowsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RowsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RowsBox.FormattingEnabled = true;
            this.RowsBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RowsBox.Location = new System.Drawing.Point(433, 35);
            this.RowsBox.Name = "RowsBox";
            this.RowsBox.Size = new System.Drawing.Size(59, 29);
            this.RowsBox.TabIndex = 3;
            this.RowsBox.Text = "Row";
            this.RowsBox.SelectedValueChanged += new System.EventHandler(this.RowsBox_SelectedValueChanged);
            // 
            // ColBox
            // 
            this.ColBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColBox.FormattingEnabled = true;
            this.ColBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ColBox.Location = new System.Drawing.Point(368, 35);
            this.ColBox.Name = "ColBox";
            this.ColBox.Size = new System.Drawing.Size(59, 29);
            this.ColBox.TabIndex = 4;
            this.ColBox.Text = "Col";
            this.ColBox.SelectedValueChanged += new System.EventHandler(this.ColBox_SelectedValueChanged);
            // 
            // ResLabel
            // 
            this.ResLabel.AutoSize = true;
            this.ResLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResLabel.Location = new System.Drawing.Point(9, 398);
            this.ResLabel.Name = "ResLabel";
            this.ResLabel.Size = new System.Drawing.Size(59, 21);
            this.ResLabel.TabIndex = 5;
            this.ResLabel.Text = "Result:";
            // 
            // AlgLabel
            // 
            this.AlgLabel.AutoSize = true;
            this.AlgLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgLabel.Location = new System.Drawing.Point(9, 38);
            this.AlgLabel.Name = "AlgLabel";
            this.AlgLabel.Size = new System.Drawing.Size(125, 21);
            this.AlgLabel.TabIndex = 6;
            this.AlgLabel.Text = "Algorithm type:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.Location = new System.Drawing.Point(279, 38);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(83, 21);
            this.SizeLabel.TabIndex = 7;
            this.SizeLabel.Text = "Table size:";
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(612, 24);
            this.MenuBar.TabIndex = 8;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(506, 35);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 29);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SolveBtn
            // 
            this.SolveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SolveBtn.Location = new System.Drawing.Point(525, 395);
            this.SolveBtn.Name = "SolveBtn";
            this.SolveBtn.Size = new System.Drawing.Size(76, 29);
            this.SolveBtn.TabIndex = 10;
            this.SolveBtn.Text = "Solve";
            this.SolveBtn.UseVisualStyleBackColor = true;
            this.SolveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // SimplexAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(612, 434);
            this.Controls.Add(this.SolveBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.AlgLabel);
            this.Controls.Add(this.ResLabel);
            this.Controls.Add(this.ColBox);
            this.Controls.Add(this.RowsBox);
            this.Controls.Add(this.MatrixView);
            this.Controls.Add(this.AlgorithmBox);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "SimplexAlgorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplex Algoritm";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixView)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.ComboBox AlgorithmBox;
        private System.Windows.Forms.DataGridView MatrixView;
        private System.Windows.Forms.ComboBox RowsBox;
        private System.Windows.Forms.ComboBox ColBox;
        private System.Windows.Forms.Label ResLabel;
        private System.Windows.Forms.Label AlgLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SolveBtn;
    }
}

