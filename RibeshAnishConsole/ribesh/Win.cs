using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibeshAnishConsole.ribesh
{
    class Win : Form
    {
        Button b = new Button();
        TextBox t = new TextBox();
        ListBox l = new ListBox();
        GroupBox g = new GroupBox();
        RadioButton r1 = new RadioButton();
        RadioButton r2 = new RadioButton();
        CheckBox c1 = new CheckBox();
        CheckBox c2 = new CheckBox();



        public Win()
        {
            l.SelectedIndexChanged += L_SelectedIndexChanged;
            this.Size = new System.Drawing.Size(500, 500);
            g.Size = new System.Drawing.Size(400, 400);
            l.Location = new System.Drawing.Point(10, 10);
            b.Location = new System.Drawing.Point(10, 350);
            c1.Location = new System.Drawing.Point(10, 150);
            c2.Location = new System.Drawing.Point(10, 170);
            r1.Location = new System.Drawing.Point(10, 210);
            r2.Location = new System.Drawing.Point(10, 230);
            t.Location = new System.Drawing.Point(10, 260);
            b.Text = "ok";
            l.Items.AddRange(new string[] { "red", "blue", "green" });
            r1.Text = "male";
            r2.Text = "female";
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
            string selectedvalue =Convert.ToString( (sender as ListBox).SelectedItem);
            switch(selectedvalue)
            {
                case "red":
                    g.BackColor = System.Drawing.Color.Red;
                    break;
                case "blue":
                    g.BackColor = System.Drawing.Color.Blue;
                    break;
                case "green":
                    g.BackColor = System.Drawing.Color.Green;
                    break;

            }
        }
    }
















            







            

    
}
