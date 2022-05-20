using System;

namespace lesson
{
    partial class Person
    {
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
