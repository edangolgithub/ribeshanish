using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ribeshanish.Anish
{
    class Anisform : Form
    {
        TextBox a;
        Button b;
        public Anisform()
        {
            a = new TextBox();
            a.Location = new Point(200, 200);
            a.Multiline = true;
            a.Height = 100;
            b = new Button();
            b.Text = "hehe";
            b.Font = new Font("Comic sans MS", 10, FontStyle.Italic);
            b.Location = new Point(100, 110);
            b.Height = 100;
            





            this.Width = 500;
            this.Width = 500;
            this.BackColor = Color.Pink;
            this.Controls.Add(a);
            this.Controls.Add(b);
        }

    }
}
