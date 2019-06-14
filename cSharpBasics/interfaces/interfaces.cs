//interfaces contain onl abstract methods 
//abstract methods contain both abstract and non abstract classes

//Non-abstract methods : Methods with method body
//Abstract methods: Methods without method body 

//every abstract method of an interrface must be implimented by the child class of the interface

//all interfaces must be implimented in derived class
//While naming an interface use I<interfacename>

//interface's default scope is public (for classes it is private)

//objects cannot be created for interfaces
//we cannot declare variables in an interface

interface <interface name>
{
	//abstract methods only
}

//defining abstract methods in interface

interface <interface name>
{
	<return type specifier> <function name> (<args>);  //no need for <scope> abstract before return type
}

//for eg:
interface IaMInterface
{
    int add(int a, int b);
	int sub(int a,int b);

}

