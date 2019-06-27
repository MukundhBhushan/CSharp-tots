using System.Collections.Generic;

namespace collections
{
    public class QueueClass
    {
        public Queue<int> arr = new Queue<int>(); //create an object to access this Array
        public static void Main()
        {
            //genric stack ie similar datatypes
            QueueClass obj = new QueueClass(); //creating the object for the "ArrayListClass" to access the arraylist
            obj.arr.Enqueue(1);
            obj.arr.Enqueue(2);
            obj.arr.Enqueue(3);
            obj.arr.Dequeue();

            //Non genric stack ie different data types
            Queue<int> arr2 = new Queue<int>(); //No access sepcifier when declared in main
            obj.arr.Enqueue(1);
            obj.arr.Enqueue(2);
            obj.arr.Enqueue(3);
            obj.arr.Dequeue();

            //Printing the queue
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}