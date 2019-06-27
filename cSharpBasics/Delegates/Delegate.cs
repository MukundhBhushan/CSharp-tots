namespace cSharpBasic
{
    public delegate void print();
    class baseClass
    {
        public static void Disp()
        {
            Console.writeline("this is static method");
        }

        public static void main(string[] args)
        {
            print objDel = new print(Disp);
            objDel();

        }
    }
}