using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfInheritance
{
    class Parent
    {
        public virtual void FirstMethod()
        {
            Console.WriteLine("First Method of Parent is executed");
        }

        public virtual void SecondMethod()
        {
            Console.WriteLine("Second Method of Parent is executed");
        }
    }
}
