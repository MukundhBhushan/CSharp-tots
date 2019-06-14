namespace SealedClass
{
    public sealed class Person
    {
        public void printInfo()
        {
            Console.Writeline("This is my info");
        }

    }

    public sealed class Recharge
    {
        static void Main(string[] args)
        {        
            Person person = new Person();
            person.printInfo();
        }
    }

}