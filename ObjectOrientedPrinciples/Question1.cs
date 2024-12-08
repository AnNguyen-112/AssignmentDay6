using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//1.Write a program that that demonstrates use of four basic principles of
//object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
///Polymorphism/.

namespace AssignmentDay6.ObjectOrientedPrinciples
{
    internal class Question1
    {
    }

    public abstract class Employee
    {
        // Encapsulation: 
        private string name;
        private string position;

        // Property to encapsulate 'name'
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property to encapsulate 'position'
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Abstract method
        public abstract void Work();

        // Constructor for Employee class
        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }


    }

    public class Nurse: Employee
    {
        public Nurse(string name, string position) : base(name, position)
        {
        }

        //overriding method (run time polymorphism)
        

        //Polymorphism compile time, overloading
        public  void Work(string title)
        {
            Console.WriteLine($"I am a {title} nurse");

        }

        public override void Work()
        {
            Console.WriteLine("I am a nurse");

        }
    }

    public class Doctor : Employee
    {
        public Doctor(string name, string position) : base(name, position)
        {
        }

        public override void Work()
        {
            Console.WriteLine("I am a doctor");

        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create employees: Nurse, Doctor, and Janitor
    //        Nurse nurse = new Nurse("John", "Nurse");
    //        Doctor doctor = new Doctor("Sarah", "Doctor");

    //        nurse.Work();
    //        nurse.Work("Senior");
    //        doctor.Work();
            

    //    }
    //}


}
