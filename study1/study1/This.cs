using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class Soldier
    {
        private string Name;
        private string Position;

        public void Setname(string Name)
        {
            this.Name = Name;
        }
        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetPosition()
        {
            return this.Position;
        }
    }

    class MainApp6
    {
        static void Main()
        {
            Soldier hoban = new Soldier();
            hoban.Setname("banho");
            hoban.SetPosition("poilot");
            Console.WriteLine($"{hoban.GetName()} {hoban.GetPosition()}");

            Soldier tigger = new Soldier();
            tigger.Setname("Tigger");
            tigger.SetPosition("hash");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}
