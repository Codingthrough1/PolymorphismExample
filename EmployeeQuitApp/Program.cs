using System;

namespace EmployeeQuitApp
{
    // Interface definition
    public interface IQuittable
    {
        void Quit();
    }

    // Employee class implementing interface
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            IQuittable quittableEmployee = emp;
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
