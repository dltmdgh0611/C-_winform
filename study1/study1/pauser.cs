using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class Dog
    {
        public string Name;
        public string Color;
        public Dog()
        {
            Name = "";
            Color = "";
        }
        public Dog(string _Name,string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Dog()
        {
            Console.WriteLine($"{Name} : go away");
        }
    }
    class MainApp3
    {
        public static void Main()
        {
            Dog A = new Dog();
            A.Name = "sophy";
            A.Color = "Living Coral";
            Dog B = new Dog("mungmungyee","rainbow");
            Console.WriteLine($"{A.Name} : {A.Color}");
            Console.WriteLine($"{B.Name} : {B.Color}");
        }
    }
}
