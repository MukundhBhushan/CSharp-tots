using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasic
{
    //ASSUME this class is in a different project but in the same solution
    class NoInheritedClass_in_differentPro
    {
        static void Main()
        {
            cSharpBasic.baseClass obj = new cSharpBasic.baseClass();

            //all the methods that can be called
            obj.PublicMethod();
            //no other method can be called
        }
       

        

    }
}
