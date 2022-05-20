using System;


namespace lesson
{
    class MyClass
    {
        public const double PI = 3.14;

        public const string MY_ERROR = "error";

        public MyClass()
        {

        }

        public void Foo()
        {
            Console.WriteLine(PI);
            Console.WriteLine(MY_ERROR);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Foo();
        }
    }
}
