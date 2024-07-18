using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent1 = new Parent();
            parent1.FirstMethod();
            parent1.SecondMethod();

            Child child1 = new Child();
            child1.FirstMethod();
            child1.SecondMethod();

            /* Reference of Parent and runtime object of child is used to execute 
             * Parent specific methods if child does not contain those method
             * */
            Parent parent2 = new Child();
            parent2.FirstMethod();
            parent2.SecondMethod();
        }
    }
}
