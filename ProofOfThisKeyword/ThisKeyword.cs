using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfThisKeyword
{
    class ThisKeyword
    {
        public string Name;
        public int Age;


        // Getters
        public string GetName() { return Name; }
        public int GetAge() { return Age; }

        // Setters
        public void SetName(string name) {this.Name = name;}
        public void SetAge(int age) {this.Age = age;}
    }
}
