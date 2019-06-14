Types of classes:
- Concreate / default class
- abstract class
- sealed class
- static class
- partial class

#Abstract class
- cannot be private as it needs to be inherited
- combination of abstract members and non abstract members
- Abstract class can contains declaration only no function implimentation
- abstract members do not have implimentation 
- non abstract members have implimentation
- for abstract class we cannont create an object

abstract method: a method without a method body 
abstract class: a class with abstract method

use "override" keyword while implimenting the class in the child classes

use this type of methods when the function is same but operation in the child classes are different 
for instance: if we are to take the area of an rectangle and cone the function getarea is same but operation is different

the abstract methods must be implimented by all the child classes (ie classes which inherit from the abtract base class)

#Difference between abstract class and interface
##Abstract class
- it contains abstract as well as non abstract members
- abstract members do not implimentation and non abstract members have implimentation
- can give access modifier(public, private) to abstract method
- all abstract class methods need not be impliment in derived class 
- abstract methods must be implimented in derived class
- abstract class can have constructor
- does not support multiple inheritance
- no obj can be created
##interface
- has only method declaration but no implimentation
- cannot give access modifier to interface
- all interrface methods are public by default
- all interface members must be implimented in derived class
- interface does not contain constructor
- interface supports mulitple inheritance
- no obj can be created

#Sealed class
- removes the concept of inheritance form the class ie these classes cannot be inherited
- objects can be created within the namespace
- the class doesnot need to be inherited to create an obj for
- public, internal can only be used not others as the if others are used an object cannot be created in otherr classes

#Static Class
- contains static methods only
- to init the static prop we must use static constructor
- obj cannot be created for static classes
- all static members can be asscess with class reference
#Partial class
- divides the code into no of classes class name will be same for all the classes 
- before class name "partial" keyword is to be used
- properties and methods can be accessed accros all the partial classes with similar 
- when the application is complined all the partial classes act as a single class
- varibles with similar name as well as signature cannot be created in multiple classes
    - eg : public int a in class a
            public int a in class b can not be created float can be used instead