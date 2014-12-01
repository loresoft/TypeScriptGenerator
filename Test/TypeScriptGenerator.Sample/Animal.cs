using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScriptGenerator.Sample
{
    public abstract class Pet
    {
        public string Name { get; set; }

        public int Age { get; set; }

    }

    public class Dog : Pet
    {
        public string Bread { get; set; }
    }

    public class Cat : Pet
    {
        public string Family { get; set; }
    }
}
