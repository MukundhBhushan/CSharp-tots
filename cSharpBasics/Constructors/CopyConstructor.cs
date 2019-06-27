namespace cSharpBasic
{
    class baseClass
    {
        int birdAge;
        string birdName;
        //paramterless
        baseClass(baseClass bs)
        {
            bs.birdAge = 25;
            bs.birdName = "Eagle";
        }

        public void Main(string[] args)
        {
            baseClass obj1 = new baseClass();
            baseClass obj2 = new baseClass(12,"sparrow");
        }

    }

}