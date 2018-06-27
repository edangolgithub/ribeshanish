using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish.forms
{
    public partial class world_cup_winner : Form
    {
        public world_cup_winner()
        {
            InitializeComponent();
        }

        private void world_cup_winner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show(radioButton1.Text + "will win the world cup");
            }

            else if (radioButton2.Checked == true)
            {
                MessageBox.Show(radioButton2.Text + "will win the world cup");
            }


            else if (radioButton3.Checked == true)

            {
                MessageBox.Show(radioButton3.Text + "will win the world cup");
            }

            else if (radioButton4.Checked == true)
            {
                MessageBox.Show(radioButton4.Text + "will win the world cup");
            }














        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Text + " was checked");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton2.Text + " was checked");
        }
    }
}
