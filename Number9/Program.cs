using System;

namespace Number9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", 2, "90999900", "New York");
            Console.WriteLine($"{student.Name}, Roll No: {student.RollNo}, Phone No: {student.PhoneNo}, Address:{student.Address}");

            Student student2 = new Student("Sam", 3, "909999900", "Chicago");
            Console.WriteLine($"{student2.Name}, Roll No: {student2.RollNo}, Phone No: {student2.PhoneNo}, Address:{student2.Address}");
        }
    }
}
