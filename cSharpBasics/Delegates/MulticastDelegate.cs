namespace cSharpBasic
{
    public delegate void Calc(int a);
    
    class baseClass
    {
        public static void Add(int a)
        {
            Console.writeline($"the Addition: {a + 10}");
        }

        public static void Sub(int a)
        {
            Console.writeline($"the Addition: {a + 10}");
        }
        public static void Mul(int a)
        {
            Console.writeline($"the Addition: {a + 10}");
        }
        public static void Div(int a)
        {
            Console.writeline($"the Addition: {a + 10}");
        }

        public static void main(string[] args)
        {
            Calc CalDele1 = new Calc(add);
            Calc CalDele2 = new Calc(sub);
            Calc CalDele3 = new Calc(Mul);
            Calc CalDele4 = new Calc(Div);
            Calc CalDele = CalDele1+CalDele2+CalDele3+CalDele4; // to call all the delegates at once

            // this could also be done in 
            Calc CalDele = new Calc(add);
            CalDele += new Calc(sub);
            CalDele += new Calc(Mul);
            CalDele += new Calc(Div); //appends all the methods to "CalDel" and can be called directly

            CalDele(12); // the calls for both of the init methods are the same

        }
    }
}