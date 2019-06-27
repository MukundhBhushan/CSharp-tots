using System.Collections.Generic;

namespace collections
{
    public class StackClass
    {
        public Stack<int> arr = new Stack<int>(); //create an object to access this Array
        public static void Main()
        {
            //genric stack ie similar datatypes
            StackClass obj = new StackClass(); //creating the object for the "ArrayListClass" to access the arraylist
            obj.arr.Push(1);
            obj.arr.Push(2);
            obj.arr.Push(3);
            obj.arr.Pop();

            //Non genric stack ie different data types
            Stack<int> arr2 = new Stack<int>(); //No access sepcifier when declared in main
            arr2.Push(1);
            arr2.Push(2);
            arr2.Push(3);
            arr2.Pop();

            //Printing the stack
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}