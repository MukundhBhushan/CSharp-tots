namespace StaticClass
{
    static class PersonDetails
    {
        static string name;
        static int age;
        static PersonDetails()
        {
            name = "Name";
            age = 19;

        }

    }

    class Recharge
    {
        static void Main(string[] args)
        {
            Console.Writeline(PersonDetails.name);
            Console.Writeline(PersonDetails.age);
            Console.Read();
        }       
    }

}
