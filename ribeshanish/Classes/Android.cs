using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ribeshanish.Classes
{
    public class Android
    {

        public string company;
        public string modelnumber;
        public int ramsize;
        public int internalmemory;
        public string colortypes;
        public int version;
        public int price;
        public int frontcamera;
        public int backcamera;

        public void view()
        {
            Console.WriteLine("the name of company is " + company);
            Console.WriteLine("the modelnumber of android mobile is " + modelnumber);
            Console.WriteLine("the ramsize of mobile is  " + ramsize +  "gb");
            Console.WriteLine("the internalmemory of mobile is  " + internalmemory +  "gb");
            Console.WriteLine("the colortypes of mobile are  " + colortypes);
            Console.WriteLine("the version of this mobile is  " + version);
            Console.WriteLine("the price of mobile is  " +  "Rs "  + price);
            Console.WriteLine("the front camera of this mobile is  " + frontcamera + "mp");
            Console.WriteLine("the backcamera of this mobile is  " + backcamera + "mp");


        }
    }
}
