using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibeshAnishConsole.evan
{
    class win :Form
    {
        Button b = new Button();
        TextBox t = new TextBox();
        public win()
        {
            b.Text = "this is ribesh button";
            
          

            this.Controls.Add(b);
            this.Controls.Add(t);
        }

    }
}
