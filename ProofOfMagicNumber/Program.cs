using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfMagicNumber
{
    class Program
    {
        public const int DIVISOR = 2;
        public string ReturnEvenNumber(int number)
        {
            return number % DIVISOR == 0 ? $"{number} is Even" : $"{number} is Odd";
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.ReturnEvenNumber(75));

            Console.WriteLine(program.ReturnEvenNumber(100));

            Console.WriteLine(program.ReturnEvenNumber(55));
        }
    }
}
