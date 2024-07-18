using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfInheritance
{
    class Child:Parent
    {
        public override void FirstMethod()
        {
            Console.WriteLine("First Method of Child is executed");
        }

        public override void SecondMethod()
        {
            Console.WriteLine("Second Method of Child is executed");
        }
    }
}
