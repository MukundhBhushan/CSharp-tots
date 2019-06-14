using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasic
{
    class noInheritance
    {
        static void Main()
        {
            //calling the methods of the class "program" by creating an instance of it instead of inheriting it
            baseClass proObj = new baseClass();

            //all the possible methods that can be called

            proObj.internalMethod();
            proObj.PublicMethod();
            proObj.ProtectedInternalMethod();

            // methods except private protected can be called
        }

    }
}

