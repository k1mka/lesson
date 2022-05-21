using System;


namespace lesson
{
    class MyClass
    {
        public string Name { get; set; }

        public string lastName { get; set; }

        public MyClass()
        {
            this.Name = Name;
            this.lastName = lastName;
        }

        public void Foo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(lastName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Name = "Артем";
            myClass.lastName = "Пономаренко";

            MyClass myClass1 = new MyClass
            {
                Name = "Жора",
                lastName = "Откидной"
            };
            myClass.Foo();

            Console.WriteLine();

            myClass1.Foo();


        }
    }
}
