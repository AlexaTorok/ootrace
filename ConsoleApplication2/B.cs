using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class B : A
    {
        protected void S4()
        {
            Console.WriteLine("B::S4");
            V1();
        }

        public void S5()
        {
            Console.WriteLine("B::s5");
            S3();
        }

        protected void S3()
        {
            Console.WriteLine("B::s3");

        }

        public virtual void V2()
        {
            Console.WriteLine("B::v2");
            V1();
        }

        protected virtual void V1()
        {
            Console.WriteLine("B::v1");
            S5();
        }
    }
}