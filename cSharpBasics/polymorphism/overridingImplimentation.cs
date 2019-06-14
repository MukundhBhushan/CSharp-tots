using System;

namespace cSharpBasic
{
    class baseClass
    {
        public virtual int add(int a, int b)
        {
            return a+b;
        }
    }

    class derivedclass: baseClass
    {
        public override add(float a, float b)
        {
            base.add(1,2); // invoke the base class add function
            //base keyword can be used only within the class definition not in the void main function
            return b+a;
        }
    

        static void Main(string[] args)
        {
            derivedclass objD = new derivedclass();
            baseClass objB = new baseClass();
            objD.add(1,2); //calls the derived class's add method
            objB.add(1,2); //calls the base class's add method
            baseClass ob = new derivedclass(); // this is not possible because we have an overriden method in Deviverclass throws error
            derivedclass ob2 = new baseClass(); // to access base call method with out creating a new instance of the base class
        }
    }
}

