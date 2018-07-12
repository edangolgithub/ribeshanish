using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibeshAnishConsole.ribesh
{
    class Windows:Form
    {

        Button b = new Button();
        TextBox t = new TextBox();
        ListBox l = new ListBox();
        GroupBox g = new GroupBox();
        RadioButton r1 = new RadioButton();
        RadioButton r2 = new RadioButton();
        CheckBox c1 = new CheckBox();
        CheckBox c2 = new CheckBox();



        public Windows()
        {
            l.SelectedIndexChanged += L_SelectedIndexChanged;
            this.Size = new System.Drawing.Size(500, 500);
            l.Location = new System.Drawing.Point(20, 10);
            g.Size = new System.Drawing.Size(400, 400);
            c1.Location = new System.Drawing.Point(20, 150);
            c2.Location = new System.Drawing.Point(20, 170);
            r1.Location = new System.Drawing.Point(20, 210);
            r2.Location = new System.Drawing.Point(20, 230);
            t.Location = new System.Drawing.Point(20, 260);
            b.Location = new System.Drawing.Point(20, 300);
        
            b.Text = "ok";
            l.Items.AddRange(new string[] { "light yellow", "blue", "orange" });
            r1.Text = "boy";
            r2.Text = "girl";
            c1.Text = "England";
            c2.Text = "Germany";
            g.Controls.Add(l);
            g.Controls.Add(t);
            g.Controls.Add(b);
            g.Controls.Add(r1);
            g.Controls.Add(r2);
            g.Controls.Add(c1);
            g.Controls.Add(c2);
            this.Controls.Add(g);

        }

      

        private void L_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedvalue = Convert.ToString((sender as ListBox).SelectedItem);
            
            switch (selectedvalue)
            {
                case "light yellow":
                    g.BackColor = Color.LightYellow;
                    break;
                case "blue":
                    g.BackColor = System.Drawing.Color.Blue;
                    break;
                case "orange":
                    g.BackColor = System.Drawing.Color.Orange;
                    break;

            }
        }

       
    }

}

