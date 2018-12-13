using cSharpBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace accessSpecifiers
{
    class inheritedClass : baseClass

    {
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);

        }
        public static void Main()
        {
            inheritedClass inhobj = new inheritedClass();
            //all possible methods that can be called
            
            inhobj.internalMethod();
            inhobj.ProtectedInternalMethod();
            inhobj.PublicMethod();
            inhobj.ProtectedMethod();
            //all the methods except private methods can be called

            Console.ReadLine();
        }

    }



}
