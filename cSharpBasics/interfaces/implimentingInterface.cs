using System;
using IaMInterface; //import the interface
namespace cSharpBasic
{
    // all the methods in an interface must be implimented
    class impInterface: IaMInterface //inherit the interface
    {
        int IamInterface.add(int a, int b) //imp the add method
        {
            return(a+b);
        }
        int sub(int a, int b) //imp the sub method
        {
            return(a-b);
        }

    }

    static void Main(string[] args)
    {
        impInterface obj = new impInterface();
        obj.add(1,2);
        obj.sub(1,2);
    } 
}