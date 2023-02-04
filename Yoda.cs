using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigure
{
    public class Yoda
    {
          
        //properties : Hair/Hat, Head, Torso, Legs, Accessories,
        public string Hat { get; set; }
        public string Legs { get; set; }
        public string Body { get; set; }
        public string Accessories { get; set; }

        public Yoda(string hat, string legs, string body, string accessories)
        {
            Hat = hat;
            Legs = legs;
            Body = body;
            Accessories = accessories;
        }

        public void YodasAction()
        {
            Console.WriteLine($" Yoda was on a dessered island where his {Legs} legs would not work so he used the {Accessories} arms to walk around while ajusting his {Hat} that he only wore in secret");
       }
}
}
