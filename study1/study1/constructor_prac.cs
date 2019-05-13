using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class cats
    {
        public cats()
        {
            Name = "";
            Color = "";
        }
        public cats(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Name;
        public string Color;
    }
    class MainApp2
    {
        public static void Main()
        {
            cats kitty = new cats();
            kitty.Name = "kitty";
            kitty.Color = "white";
            cats nabi = new cats("nabi", "brown");
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");
            Console.WriteLine($"{nabi.Name} : {nabi.Color}");
        }
        
        
    }


}
