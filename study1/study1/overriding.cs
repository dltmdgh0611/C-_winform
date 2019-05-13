using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class amor
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class Ironman : amor
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("repulsor");
        }
    }

    class Warmachine : amor
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("micro rocket");
        }
    }

    class MainApp9
    {
        static void Main()
        {
            amor Amor = new amor();
            Amor.Initialize();

            amor Ironman = new Ironman();
            Ironman.Initialize();

            amor Warmachin = new Warmachine();
            Warmachin.Initialize();

        }
    }
}
