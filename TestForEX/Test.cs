using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForEX
{
    class Test
    {
        public abstract class Animal
        {
            public string Name;
            public int Age;
            public Animal(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            
        }
    }
}
