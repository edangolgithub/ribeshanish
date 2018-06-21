using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ribeshanish.classes
{
    class iphone
    {
        public int camera;
        public bool flashlight;
        public int storage;
        public int button;
        public decimal price;





        public void cout()
        {
            Console.WriteLine("camera "+camera+ " Mp");
            Console.WriteLine("flash" +flashlight);
            Console.WriteLine(storage +"GB "+ "internal memory");
            Console.WriteLine( button+"button");
            Console.WriteLine("Mrp " +  "Rs " + price);
        }



    }
}
