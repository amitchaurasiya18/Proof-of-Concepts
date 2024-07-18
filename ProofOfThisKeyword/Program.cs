using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfThisKeyword
{
    class Program
    { 
        static void Main(string[] args)
        {
            ThisKeyword thisKeyword = new ThisKeyword();
            thisKeyword.SetName("Amit");
            thisKeyword.SetAge(22);

            Console.WriteLine($"Name is : {thisKeyword.GetName()}\nAge is : {thisKeyword.GetAge()}");
        }
    }
}
