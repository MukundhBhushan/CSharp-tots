using System;

namespace cSharpBasic
{
    class baseClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("public method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("private method");
        }
        internal void internalMethod()
        {
            Console.WriteLine("internal method");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("protected method");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("protected internal method");
        }

        static void Main(string[] args)
        {
            baseClass obj = new baseClass();

            //all possible methods that can be called
            
            obj.internalMethod();
            obj.PrivateMethod();
            obj.ProtectedInternalMethod();
            obj.PublicMethod();
            obj.ProtectedMethod();
            //all the methods can be called

            Console.ReadLine();

        }
    }
}
