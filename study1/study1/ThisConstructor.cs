using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class ThisConstructor
    {
        int a, b, c;
        public ThisConstructor() // 생성자
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }
        public ThisConstructor(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }
        public ThisConstructor(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b},{c})");
        }
        public void Print()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }

    class MyClass7
    {
        static void Main()
        {
            
            ThisConstructor a = new ThisConstructor();
            a.Print();
            Console.WriteLine();

            ThisConstructor b = new ThisConstructor(20,10);
            b.Print();
            Console.WriteLine();

            ThisConstructor c = new ThisConstructor(10);
            c.Print();
        }
    }
}
