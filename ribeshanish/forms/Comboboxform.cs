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
    public partial class Comboboxform : Form
    {
        string[] fteams = { "brazil" , "colombia" ,"argentina" , "germany" };





        public Comboboxform()
        {
            InitializeComponent();
            fillcombobox();
        }

        public void fillcombobox()
        {
            comboBox2.Items.AddRange(fteams);
        }





    }
}
