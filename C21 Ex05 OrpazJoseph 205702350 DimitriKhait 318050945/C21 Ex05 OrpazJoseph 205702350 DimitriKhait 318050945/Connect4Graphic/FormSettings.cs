using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Connect4Graphic
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void checkBoxPlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPlayerTwo.Enabled = CheckBoxPlayerTwo.CheckState == CheckState.Checked;
            if (TextBoxPlayerTwo.Enabled)
            {
                TextBoxPlayerTwo.Text = "Player2";
            }
            else
            {
                TextBoxPlayerTwo.Text = "[Computer]";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // $G$ SFN-999 (-8) Game information window should be closed after the user clicks save
            FormGame formGame = new FormGame();
            formGame.ShowDialog();
        }
    }
}
