using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ribeshanish.Classes
{
   public class Person
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Gender { get; set; }
        public List<string> Football { get; set; }
        public String Phone { get; set; }
        public Person()
        {
            Football = new List<string>();
        }
    }
}
