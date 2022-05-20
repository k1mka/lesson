namespace lesson
{
    partial class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Рома", "Обезьянович");
            person.PrintFullName();
        }
    }
}
