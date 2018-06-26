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
    public partial class CheckboxForm1 : Form
    {
        public CheckboxForm1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(checkBox5.Text);
        }
       // List<string> s1 = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Control c in this.Controls)
            {
                if( c is CheckBox)
                {
                    CheckBox c1 = (CheckBox)c;
                    if (c1.Checked == true)
                    {
                        listBox1.Items.Add(c1.Text);
                        listBox1.Sorted = true;
                    }
                }
            }
           // listBox1.Items.AddRange(s1.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(americacheckbox.Checked==true)
            {
                listBox1.Items.Add(americacheckbox.Text);
            }
            if(checkBox2.Checked==true)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
            }
            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add(checkBox5.Text);
            }
            if (checkBox6.Checked == true)
            {
                listBox1.Items.Add(checkBox6.Text);
            }
        }
    }
}
