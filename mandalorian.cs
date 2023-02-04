using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigure
{
    public class mandalorian
    {
        //properties : Hair/Hat, Head, Torso, Legs, Accessories,
        public string Hat { get; set; }
        public string Legs { get; set; }
        public string Body { get; set; }
        public string Accessories { get; set; }


        public mandalorian( string hat, string legs, string body, string accessories )
        {
            Hat= hat;
            Legs= legs;
            Body= body;
            Accessories= accessories;
        }



        // Console.WriteLine("Everything is awesome");
        public void BabyYoda()
        {
            Console.WriteLine($"The Baby Yoda ajusted his {Hat} while he waddled his {Legs} arms over to see his protector");
        }



    }
}

