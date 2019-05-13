using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class Global // 정적 필드
    {
        public static int count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.count++;
        }
    }

    class MainApp4
    {
        public static void Main()
        {
            Console.WriteLine($"Global.count:{Global.count}");
            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();
            Console.WriteLine($"Global.count:{Global.count}");
        }
    }
}

