using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {
        internal string Name;

      public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $" {Name}";

        }

    }

    internal class Teacher : Person
    {
        
       public  Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("teacher is explaining");
        }


    }

    internal class Student : Person
    {
        public Student(String name): base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("student is studying");
        }
    }

}
