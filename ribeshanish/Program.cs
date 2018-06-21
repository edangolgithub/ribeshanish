using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



using ribeshanish.classes;

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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Animal a = new Animal();
        
            //a.eyecolor = "red";
            //a.numoflegs = 4;
            //a.display();


            //Animal b = new Animal();
            //b.eyecolor = "green";
            //b.numoflegs = 8;
            //b.display();


            //Human h = new Human();
            //h.hair = "brown";
            //h.fingers = 10;
            //h.output();


            //Computer c =new Computer();
            //c.ram = 8;
            //c.rom = 64;
            //c.seenout();


            iphone fives = new iphone();
            fives.backcamera = 15;
            fives.frontcamera = 8;
            fives.ios = 10;
            fives.flashlight = true;
            fives.storage = 16;
            fives.button = 1;



            fives.price = 5200;

            fives.cout();





            
        }

    
           
        }


       
    }

