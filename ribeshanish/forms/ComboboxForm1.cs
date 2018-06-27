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
    public partial class ComboboxForm1 : Form
    {

        string[] fteams = { "brazil", "colombia", "germany", "argentina" };

        public ComboboxForm1()
        {
            InitializeComponent();

            //comboBox2.Items.AddRange(fteams);



            comboBox2.Items.Add("q");
            comboBox2.Items.Add("dsfq");

            comboBox2.Items.Add("fdgfdq");

            comboBox2.Items.Add("fdgf");

        }


    }
}
