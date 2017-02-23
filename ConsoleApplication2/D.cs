using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class D : B
    {
        public void S7()
        {
            Console.WriteLine("D::s7");
            S3();
        }

        public void S8()
        {
            Console.WriteLine("D::s8");
            V2();
        }

        protected virtual void V2()
        {
            Console.WriteLine("D::v2");
            S7();
        }
    }
}