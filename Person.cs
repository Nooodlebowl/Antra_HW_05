using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra_HW_05
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public virtual void speak() 
        {
            Console.WriteLine("Hello, I am a person");
        }
    }
    public class Student : Person
    {
        public override void speak()
        {
            Console.WriteLine("Hello, I am a student");
        }
    }

    public class Teacher : Person
    {
        public override void speak()
        {
            Console.WriteLine("Hello, I am a Teacher");
        }
    }
}
