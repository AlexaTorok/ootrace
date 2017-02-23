using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class C : B
    {
        public void S6()
        {
            Console.WriteLine("C::s6");
            V1();
        }

        public void S7()
        {
            Console.WriteLine("C::s7");
            V2();
        }
    }
}