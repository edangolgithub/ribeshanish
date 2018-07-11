using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ribeshanish.Ribesh
{
    class RibeshForm : Form
    {
        TextBox textbox1;
        Button button1;

        public RibeshForm()
        {
            button1 = new Button();
            textbox1 = new TextBox();
            textbox1.Location = new Point(100, 100);
            textbox1.Multiline = true;

            textbox1.Height = 150;

            textbox1.Text = "I am human";
            textbox1.Font = new Font("COMIC SANS MS", 18, FontStyle.Italic);
            button1.Text = "verify";
            button1.Height = 85;

           
            button1.Location = new Point(150, 150);

            
            this.Controls.Add(textbox1);
            this.Controls.Add(button1);
            
        }
    }
}
