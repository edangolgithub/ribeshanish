using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ribeshanish.Classes;

namespace ribeshanish.forms
{
    public partial class aboutandroid : Form
    {
        public aboutandroid()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Android myandroid = new Android();
            myandroid.backcamera = 20;
            myandroid.colortypes = "red, black,navy blue, white, metallic grey and golden ";
            myandroid.company = "samsung";
            myandroid.frontcamera = 8;
            myandroid.internalmemory = 132;
            myandroid.modelnumber = "galaxy j10 new";
            myandroid.price = 68000;
            myandroid.ramsize = 3;
            myandroid.version = 7;

            companytextbox.Text = myandroid.company;
            mdltextbox.Text = myandroid.modelnumber;
            bkcamtextbox.Text = Convert.ToString(myandroid.backcamera);
            frcamtextbox.Text = Convert.ToString(myandroid.frontcamera);
            intmemtextbox.Text = Convert.ToString(myandroid.internalmemory);
            colortextbox.Text = myandroid.colortypes;
            pricetextbox.Text = Convert.ToString(myandroid.price);
            ramsizetextbox.Text = Convert.ToString(myandroid.ramsize);
            versiontextbox.Text = Convert.ToString(myandroid.version);
                 
                         
        }
    }
}
