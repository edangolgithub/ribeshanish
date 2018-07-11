using System;
using System.Windows.Forms;

namespace ribeshanish.Ribesh
{
    class Program
    {
        public Program()
        {
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ribesh.Pyramid());


    
           

        }
    }
}