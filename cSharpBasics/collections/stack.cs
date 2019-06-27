using System.Collections;

namespace collections
{
    public class StackClass
    {
        public Stack arr = new Stack(); //create an object to access this Array
        public static void Main()
        {
            StackClass obj = new StackClass();
            obj.arr.Push("Mukundh");
            obj.arr.Push(1);
            obj.arr.Push(1.2);
            obj.arr.Pop();
            //Non genric stack ie different data types
            Stack arr2 = new Stack(); //No access sepcifier when declared in main
            arr2.Push("Mukundh");
            arr2.Push(1);
            arr2.Push(1.2);
            arr2.Pop();

            //Printing the stack
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}