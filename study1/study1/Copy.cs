using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    class MyClass
    {
        public int Field1, Field2;
        
        public MyClass DeepCopy() // 깊은 복사
        {
            MyClass deepcopy = new MyClass();
            deepcopy.Field1 = this.Field1;
            deepcopy.Field2 = this.Field2;
            return deepcopy;
        }
    }
    class MainApp5
    {
        static void Main()
        {
            Console.WriteLine("얇은 복사");
            {
                MyClass source = new MyClass();
                source.Field1 = 10;
                source.Field2 = 20;

                MyClass target = source;
                target.Field2 = 30;

                Console.WriteLine($"{source.Field1} {source.Field2}");
                Console.WriteLine($"{target.Field1} {target.Field2}");
            }

            Console.WriteLine("깊은 복사");
            {
                MyClass source = new MyClass();
                source.Field1 = 10;
                source.Field2 = 20;

                MyClass target = source.DeepCopy();
                target.Field2 = 30;

                Console.WriteLine($"{source.Field1} {source.Field2}");
                Console.WriteLine($"{target.Field1} {target.Field2}");
            }
        }
    }

}
