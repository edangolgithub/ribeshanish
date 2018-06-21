using ribeshanish.Classes;
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
    public partial class AndroidForm : Form
    {
        public AndroidForm()
        {
            InitializeComponent();

            comboBox1.Items.Add("samsung");
            comboBox1.Items.Add("huwaei");
            comboBox1.Items.Add("gionee");
            comboBox1.Items.Add("nokia");
            comboBox1.Items.Add("lenovo");
            comboBox1.Items.Add("lava");
            comboBox1.Items.Add("colors");
            comboBox1.Items.Add("karbon");
            comboBox1.Items.Add("intex");
            fillinformation();
        }
        Android samsung = new Android();
        Android nokia = new Android();
        void fillinformation()
        {
            
            samsung.backcamera = 20;
            samsung.colortypes = "red, black,navy blue, white, metallic grey and golden ";
            samsung.company = "samsung";
            samsung.frontcamera = 8;
            samsung.internalmemory = 132;
            samsung.modelnumber = "galaxy j10 new";
            samsung.price = 68000;
            samsung.ramsize = 3;
            samsung.version = 7;

           
            nokia.backcamera = 68;
            nokia.colortypes = "red, black,navy blue, white, metallic grey and golden ";
            nokia.company = "nokia";
            nokia.frontcamera = 16;
            nokia.internalmemory = 324;
            nokia.modelnumber = "nokia 12";
            nokia.price = 79000;
            nokia.ramsize = 3;
            nokia.version = 7;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = Convert.ToString(comboBox1.SelectedItem);
            label10.Text = choice;

           switch(choice)
            {
                case "samsung":
                    companytextbox.Text = samsung.company;
                    mdltextbox.Text = samsung.modelnumber;
                    bkcamtextbox.Text = Convert.ToString(samsung.backcamera);
                    frcamtextbox.Text = Convert.ToString(samsung.frontcamera);
                    intmemtextbox.Text = Convert.ToString(samsung.internalmemory);
                    colortextbox.Text = samsung.colortypes;
                    pricetextbox.Text = Convert.ToString(samsung.price);
                    ramsizetextbox.Text = Convert.ToString(samsung.ramsize);
                    versiontextbox.Text = Convert.ToString(samsung.version);
                    break;

                case "nokia":
                    companytextbox.Text = nokia.company;
                    mdltextbox.Text = nokia.modelnumber;
                    bkcamtextbox.Text = Convert.ToString(nokia.backcamera);
                    frcamtextbox.Text = Convert.ToString(nokia.frontcamera);
                    intmemtextbox.Text = Convert.ToString(nokia.internalmemory);
                    colortextbox.Text = nokia.colortypes;
                    pricetextbox.Text = Convert.ToString(nokia.price);
                    ramsizetextbox.Text = Convert.ToString(nokia.ramsize);
                    versiontextbox.Text = Convert.ToString(nokia.version);
                    break;
            }

        }
    }
}
