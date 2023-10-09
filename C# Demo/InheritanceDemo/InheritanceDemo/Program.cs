using System;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisitingEmployee vishal = new VisitingEmployee();
            vishal.empId = 201;

            PermanentEmployee deep = new PermanentEmployee();
            deep.empId = 101;

            Console.WriteLine(vishal.empId);
            Console.WriteLine(deep.empId);

            vishal.show();

            // 4 Types of Inheritance
            // - Single
            // - Hierarchical
            // - Multi-level
            // - Multiple (using interface)

            // 4 Pillars of OOPs
            // - Inheritance, Polymorphism, Encapsulation, Abstraction
        }
    }
}
