using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ribeshanish.evan
{
    class evanform :Form
    {
        TextBox a;
        Button b;



        public evanform()
        {
            a = new TextBox();
            b = new Button();
           
            a.Multiline = true;
            a.Height = 200;
            b.Height = 100;
            b.Text = "jkszhfdjkshfd";
            b.Font = new Font("Comic Sans MS",20, FontStyle.Bold);
            a.Location = new Point(100, 100);
            b.Location = new Point(200, 100);

          

            this.Controls.Add(a);
            this.Controls.Add(b);
        }
    }
}
