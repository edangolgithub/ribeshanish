using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ribeshanish.Classes;

namespace ribeshanish
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new forms.aboutandroid());

            Animal a = new Animal();
            a.eyecolor = "black";
            a.numberoflegs = 4;
            a.display();


            Animal b = new Animal();
            b.eyecolor = "green";
            b.numberoflegs = 2;
            b.display();

            Animal c = new Animal();
            b.eyecolor = "yellow";
            b.numberoflegs = 3;
            b.display();

            snake d = new snake();
            d.eyecolor = "green and black";
            d.numberoflegs = 0;
            d.view();

            germany r = new germany();
            r.flagcolor = "black , red and yellow";
            r.numofworldcupwon = 4;
            r.show();


            Android s = new Android();
            s.company = " samsung";
            s.modelnumber = "galaxy j10 new";
            s.ramsize = 7;
            s.internalmemory = 132;
            s.colortypes = "white, black, metallic grey, golden,  pink, navy blue";
            s.version=  7 ;
            s.price = 68000;
            s.frontcamera = 16;
            s.backcamera = 32;

            s.view();

                
                

        }
    }
}