namespace StaticClass
{
    static class PersonDetails
    {
        static string name;
        static int age;
        static PersonDetails() //static constructors
        {
            name = "Name";
            age = 19;

        }

        static print(string value)
        {
            System.Console.WriteLine(value);
        }

    }

    class Recharge
    {
        static void Main(string[] args)
        {
            Console.Writeline(PersonDetails.name);
            Console.Writeline(PersonDetails.age);
            print("hello"); //staic method no object is created to access
            Console.Read();
        }       
    }

}
