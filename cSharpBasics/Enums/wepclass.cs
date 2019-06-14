using System;
namespace enumBasic
{
    public class Wepclass
    {
        //to access elements
        var WEP = WepEnum.wep1;
        
        //as the values stored in enums are indexes int must be typecasted to eumn class name
        WepEnum wep2 = (WepEnum) Console.Read(); //Read() is tobe used as it read ints ReadLine read as string

        //creating an emum with in the class Name
        enum Fire {fire1,fire2};

        var fire = Fire.fire1;
    
    }
}
