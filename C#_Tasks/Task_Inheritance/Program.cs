// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string name = 
           //  Person p= new Person(Console.ReadLine());

            Person[] p1 = new Person[3];
           // Person p2 = new Teacher();
           // Person p3 = new Student(); 
            for(int i=0; i<p1.Length; i++)
            {
                if (i == 0)
                {
                    string name = Console.ReadLine();
                    p1[i] = new Teacher(name);
                }
                else {
                    String name= Console.ReadLine();
                    p1[i] = new Student(name);
                }
            }

            for(int j = 0; j < p1.Length; j++)
            {
                if (j == 0)
                {
                    ((Teacher)p1[j]).Explain();
                }
                else {
                    ((Student)p1[j]).Study();
                }
                
            }

            
            

        }
    }
}
