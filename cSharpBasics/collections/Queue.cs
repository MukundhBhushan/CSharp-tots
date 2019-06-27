using System.Collections;

namespace collections
{
    public class QueueClass
    {
        public Queue arr = new Queue(); //create an object to access this Array
        public static void Main()
        {
            QueueClass obj = new QueueClass();
            obj.arr.Enqueue("Mukundh");
            obj.arr.Enqueue(1);
            obj.arr.Enqueue(1.2);
            obj.arr.Dequeue();
            //Non genric stack ie different data types
            Queue arr2 = new Queue(); //No access sepcifier when declared in main
            arr2.Enqueue("Mukundh");
            arr2.Enqueue(1);
            arr2.Enqueue(1.2);
            arr22.Dequeue();

            //Printing the queue
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}