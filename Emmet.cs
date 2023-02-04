using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigure
{
    public class Emmet
    {
        //properties : Hair/Hat, Head, Torso, Legs, Accessories,
        public string Hat { get; set; }
        public string Legs { get; set; }
        public string Body { get; set; }
        public string Accessories { get; set; }

        public Emmet(string hat, string legs, string body, string accessories)
        {
            Hat = hat;
            Legs = legs;
            Body = body;
            Accessories = accessories;
        }

        public void EmmitAction()
        {
        Console.WriteLine($" Emmet threw his {Hat} and kicked his {Legs} in the air before his {Body} broke off of him and his {Accessories} were in shambles");
        }

        // Console.WriteLine("Everything is awesome");
    }
}
