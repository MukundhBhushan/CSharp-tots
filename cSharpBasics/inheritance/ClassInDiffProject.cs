using System;
using System.Collections.Generic;
using System.Text;

namespace accessSpecifiers
{
    //ASSUME this class is in a different project but in the same solution
    //to use the methods inherit or create an instance(object of the class)
    class ClassInDiffProject: cSharpBasic.baseClass
    { 

        static void Main()
        {
            ClassInDiffProject obj = new ClassInDiffProject();
            obj.ProtectedInternalMethod();
            obj.PublicMethod();
            obj.ProtectedMethod();
        }
    }
}