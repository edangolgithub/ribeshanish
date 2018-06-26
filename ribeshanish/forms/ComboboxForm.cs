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
    public partial class ComboboxForm : Form
    {

        string[] footballteams = { "BRAZIL", "GERMANY", "ARGENTINA", "PORTUGAL" };
        public ComboboxForm()
        {
            InitializeComponent();

            fillcombobox();
        }

        private void fillcombobox()
        {
            comboBox2.Items.AddRange(footballteams);
        }

        

        }
    }

