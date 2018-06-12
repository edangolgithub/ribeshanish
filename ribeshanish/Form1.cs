using System;
using System.Windows.Forms;

namespace ribeshanish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okbbutton_Click(object sender, EventArgs e)
        {
            double r;
            r =Convert.ToDouble(radiustextbox.Text);
            double area = (22 / 7) * r * r;
            MessageBox.Show(Convert.ToString(area));
        }

        private void centiconvertbtn_Click(object sender, EventArgs e)
        {
            double f;
            f = Convert.ToDouble(ferentxtbox.Text);
            double c = (f - 32) * 5 / 9;
            MessageBox.Show(Convert.ToString(c));
        }
    }
}
