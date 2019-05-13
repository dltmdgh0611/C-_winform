using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
   class A
    {
        public void Method()
        {
            Console.WriteLine("A.Method()");
        }
    }

    class B : A
    {
        public new void Method()
        {
            Console.WriteLine("B.Method()");
        }
    }

    class MainApp10
    {
        static void Main()
        {
            A Aobj = new A();
            Aobj.Method();

            B Bobj = new B();
            Bobj.Method();

            A Cobj = new B();
            Cobj.Method();
        }
    }
}
