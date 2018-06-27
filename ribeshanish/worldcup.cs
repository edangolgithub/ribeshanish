using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish
{
    public partial class worldcup : Form
    {
        Random r;

        public worldcup()
        {
            InitializeComponent();
            r = null;
            r = new Random();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firsteam = "";
            string seconteam = "";

            int playerchoice = 0;
            if (radioButton1.Checked == true)
            {
                playerchoice = 1;
            }

            else if(radioButton2.Checked==true)
            {
                playerchoice = 2;
            }
            firsteam = "Russia";
            seconteam = "Uruguya";
             processgame(playerchoice,firsteam,seconteam);

            if (radioButton3.Checked == true)
            {
                playerchoice = 1;
            }

            else if (radioButton4.Checked == true)
            {
                playerchoice = 2;
            }
            firsteam = "Spain";
            seconteam = "Morocco";
            processgame(playerchoice, firsteam, seconteam);



            if (radioButton5.Checked == true)
            {
                playerchoice = 1;
            }

            else if (radioButton6.Checked == true)
            {
                playerchoice = 2;
            }
            firsteam = "Denmark";
            seconteam = "France";
            processgame(playerchoice, firsteam, seconteam);

            if (radioButton7.Checked == true)
            {
                playerchoice = 1;
            }

            else if (radioButton8.Checked == true)
            {
                playerchoice = 2;
            }
            firsteam = "argentina";
            seconteam = "nigeria";
            processgame(playerchoice, firsteam, seconteam);


            if (radioButton9.Checked == true)
            {
                playerchoice = 1;
            }

            else if (radioButton10.Checked == true)
            {
                playerchoice = 2;
            }
            firsteam = "brazil";
            seconteam = "serbia";
            processgame(playerchoice, firsteam, seconteam);


            if (radioButton11.Checked == true)
            {
                playerchoice = 1;
            }

            else if (radioButton12.Checked == true)
            {
                playerchoice = 2;
            }
            firsteam = "germany";
            seconteam = "south korea";
            processgame(playerchoice, firsteam, seconteam);


        }

        private void processgame(int playerchoice,string fistteam,string secondteam)
        {
           
            int choice = r.Next(1, 3);
            
            if(choice==playerchoice)
            {
                if (choice == 1)
                {
                    listBox1.Items.Add(fistteam+" won "+secondteam+" lost");
                        }
                else
                        {
                    listBox1.Items.Add(secondteam + " won " + fistteam + " lost");
                }
            }
            else
            {
                if (choice == 1)
                {
                    listBox1.Items.Add(fistteam + " won " + secondteam + " lost");
                }
                else
                {
                    listBox1.Items.Add(secondteam + " won " + fistteam + " lost");
                }
            }

            
        }
    }
}
