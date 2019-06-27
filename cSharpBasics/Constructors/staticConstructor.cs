namespace cSharpBasic
{
    class baseClass
    {
        static int age;
        static string name;
        static baseClass()
        {
            age = 12;
            name = "sparrow";
        }

        public void Main(string[] args)
        {
            baseClass obj1 = new baseClass();
        }

    }

}