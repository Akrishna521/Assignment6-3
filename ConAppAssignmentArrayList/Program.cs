using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList studentGrades;
        studentGrades = new ArrayList() { 85, 92, 78, 95, 88 };
        Console.WriteLine("Student Grades:");
        foreach (var grade in studentGrades)
        {
            Console.Write(grade + " ");
        }
        Console.ReadLine();
    }
}