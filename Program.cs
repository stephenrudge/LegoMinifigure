using LegoMinifigure;

namespace LegoMiniFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yoda greenGuy = new Yoda(hat: "ballcap", legs: "short", body: "chubby", accessories: "lightsaber");
        
            greenGuy.YodasAction();

            mandalorian bodybuilder = new mandalorian("helmet", "stiff", "6-pack", "long-bow");
         
            bodybuilder.BabyYoda();

            Emmet smallGuy = new Emmet("hat", "long", "6-pack", "long-bow");
          
            smallGuy.EmmitAction();

        }
    }
}
