namespace Connect4Graphic
{
    public partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playersLabel = new System.Windows.Forms.Label();
            this.CheckBoxPlayerTwo = new System.Windows.Forms.CheckBox();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.TextBoxPlayerOne = new System.Windows.Forms.TextBox();
            this.TextBoxPlayerTwo = new System.Windows.Forms.TextBox();
            this.NumericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.colsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Location = new System.Drawing.Point(18, 14);
            this.playersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(64, 20);
            this.playersLabel.TabIndex = 0;
            this.playersLabel.Text = "Players:";
            // 
            // CheckBoxPlayerTwo
            // 
            this.CheckBoxPlayerTwo.AutoSize = true;
            this.CheckBoxPlayerTwo.Location = new System.Drawing.Point(42, 95);
            this.CheckBoxPlayerTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBoxPlayerTwo.Name = "CheckBoxPlayerTwo";
            this.CheckBoxPlayerTwo.Size = new System.Drawing.Size(95, 24);
            this.CheckBoxPlayerTwo.TabIndex = 1;
            this.CheckBoxPlayerTwo.Text = "Player 2:";
            this.CheckBoxPlayerTwo.UseVisualStyleBackColor = true;
            this.CheckBoxPlayerTwo.CheckedChanged += new System.EventHandler(this.checkBoxPlayerTwo_CheckedChanged);
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(38, 52);
            this.playerOneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(69, 20);
            this.playerOneLabel.TabIndex = 2;
            this.playerOneLabel.Text = "Player 1:";
            // 
            // TextBoxPlayerOne
            // 
            this.TextBoxPlayerOne.Location = new System.Drawing.Point(152, 48);
            this.TextBoxPlayerOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPlayerOne.MaxLength = 10;
            this.TextBoxPlayerOne.Name = "TextBoxPlayerOne";
            this.TextBoxPlayerOne.Size = new System.Drawing.Size(136, 26);
            this.TextBoxPlayerOne.TabIndex = 3;
            this.TextBoxPlayerOne.Text = "Player1";
            // 
            // TextBoxPlayerTwo
            // 
            this.TextBoxPlayerTwo.Enabled = false;
            this.TextBoxPlayerTwo.Location = new System.Drawing.Point(152, 92);
            this.TextBoxPlayerTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPlayerTwo.MaxLength = 10;
            this.TextBoxPlayerTwo.Name = "TextBoxPlayerTwo";
            this.TextBoxPlayerTwo.Size = new System.Drawing.Size(136, 26);
            this.TextBoxPlayerTwo.TabIndex = 4;
            this.TextBoxPlayerTwo.Text = "[Computer]";
            // 
            // NumericUpDownRows
            // 
            this.NumericUpDownRows.Location = new System.Drawing.Point(116, 186);
            this.NumericUpDownRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericUpDownRows.Name = "NumericUpDownRows";
            this.NumericUpDownRows.Size = new System.Drawing.Size(48, 26);
            this.NumericUpDownRows.TabIndex = 5;
            this.NumericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // NumericUpDownCols
            // 
            this.NumericUpDownCols.Location = new System.Drawing.Point(238, 186);
            this.NumericUpDownCols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericUpDownCols.Name = "NumericUpDownCols";
            this.NumericUpDownCols.Size = new System.Drawing.Size(51, 26);
            this.NumericUpDownCols.TabIndex = 6;
            this.NumericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(51, 189);
            this.rowsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(53, 20);
            this.rowsLabel.TabIndex = 7;
            this.rowsLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            this.colsLabel.AutoSize = true;
            this.colsLabel.Location = new System.Drawing.Point(189, 189);
            this.colsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colsLabel.Name = "colsLabel";
            this.colsLabel.Size = new System.Drawing.Size(44, 20);
            this.colsLabel.TabIndex = 8;
            this.colsLabel.Text = "Cols:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(22, 258);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(267, 35);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(18, 148);
            this.boardSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(91, 20);
            this.boardSizeLabel.TabIndex = 10;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 312);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.colsLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.NumericUpDownCols);
            this.Controls.Add(this.NumericUpDownRows);
            this.Controls.Add(this.TextBoxPlayerTwo);
            this.Controls.Add(this.TextBoxPlayerOne);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.CheckBoxPlayerTwo);
            this.Controls.Add(this.playersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect4 Game";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playersLabel;
        public System.Windows.Forms.CheckBox CheckBoxPlayerTwo;
        private System.Windows.Forms.Label playerOneLabel;
        public System.Windows.Forms.TextBox TextBoxPlayerOne;
        public System.Windows.Forms.TextBox TextBoxPlayerTwo;
        public System.Windows.Forms.NumericUpDown NumericUpDownRows;
        public System.Windows.Forms.NumericUpDown NumericUpDownCols;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label colsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label boardSizeLabel;
    }
}