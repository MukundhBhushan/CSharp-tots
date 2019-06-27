namespace cSharpBasic
{
    class baseClass
    {
        int birdAge;
        string birdName;
        //paramterless
        baseClass()
        {
            birdAge = 25;
            birdName = "Eagle";
        }

        //parameterized
        baseClass(int age, string name)
        {
            birdAge = age;
            birdName = name;
        }


        private baseClass()
        {
            
        }

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
            baseClass obj2 = new baseClass(12,"sparrow");
        }

    }

}