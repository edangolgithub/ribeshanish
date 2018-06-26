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
    public partial class worldcup2018 : Form
    {
        public worldcup2018()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (russiacheckBox.Checked == true)
            {
                spaincheckbox.Checked = true;
            }

            if (germanycheckBox.Checked == true)
            {
                skcheckBox.Checked = true;
            }
            if (uruguaycheckBox.Checked == true)
            {
                portugalcheckBox.Checked = true;
            }

            if (spaincheckbox.Checked == true)
            {
                russiacheckBox.Checked = true;
            }

            if (skcheckBox.Checked == true)
            {
                germanycheckBox.Checked = true;
            }
            if (portugalcheckBox.Checked == true)
            {
                uruguaycheckBox.Checked = true;
            }
        }
    }
}
