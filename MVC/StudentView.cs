using System;

namespace MVC
{
    class StudentView
    {
        public void PrintStudnetDetails(string name, int rollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Roll No: {0}", rollNo);
        }
    }
}
