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
    public partial class CheckboxForm : Form
    {
        public CheckboxForm()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(checkBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox c1 = (CheckBox)c;

                    if(c1.Checked==true)
                    {
                        listBox1.Items.Add(c1.Text);
                        listBox1.Sorted = true;
                    }
                           
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if(americacheckbox.Checked==true)
            {
                listBox1.Items.Add(americacheckbox.Text);
            }
            if (norwaycheckbox.Checked == true)
            {
                listBox1.Items.Add(norwaycheckbox.Text);
            }
            if (australiacheckbox.Checked == true)
            {
                listBox1.Items.Add(australiacheckbox.Text);
            }
            if (japancheckBox.Checked == true)
            {
                listBox1.Items.Add(japancheckBox.Text);
            }
            if (germanycheckBox.Checked == true)
            {
                listBox1.Items.Add(germanycheckBox.Text);
            }
            if (koreacheckbox.Checked == true)
            {
                listBox1.Items.Add(koreacheckbox.Text);
            }
            if (denmarkcheckbox.Checked == true)
            {
                listBox1.Items.Add(denmarkcheckbox.Text);
            }
            if (englandcheckbox.Checked == true)
            {
                listBox1.Items.Add(englandcheckbox.Text);
            }
            if (indiacheckbox.Checked == true)
            {
                listBox1.Items.Add(indiacheckbox.Text);
            }
            if (russiacheckBox.Checked == true)
            {
                listBox1.Items.Add(russiacheckBox.Text);
            }
            if (indonessiacheckBox.Checked == true)
            {
                listBox1.Items.Add(indonessiacheckBox.Text);
            }
            if (chinacheckBox.Checked == true)
            {
                listBox1.Items.Add(chinacheckBox.Text);
            }
        }
    }
}
