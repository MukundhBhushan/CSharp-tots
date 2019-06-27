using System.Collections;

namespace collections
{
    public class SortedListClass
    {
        public SortedList arr = new SortedList(); //create an object to access this Array
        public static void Main()
        {
            //genric stack ie similar datatypes
            SortedListClass obj = new SortedListClass(); //creating the object for the "ArrayListClass" to access the arraylist
            obj.arr.Add("<key>","<value>");
            obj.arr.Add(1,"Mukundh");
            obj.arr.Add(2,"Bhushan");
            obj.arr.Add(3,123);
            //Non genric stack ie different data types
            SortedList arr2 = new SortedList(); //No access sepcifier when declared in main
            arr2.Add("<key>","<value>");
            arr2.Add(1,"Mukundh");
            arr2.Add(2,"Bhushan");
            arr2.Add(3,123);

            //Printing the hashtable
            foreach (var item in arr2)
            {
                Console.WriteLine($"{item.key} \t {item.value}");
                // if "key" and "valule" are not mentioned then "DiciionaryEntry" would get printed not the keys and values
            }
        }
    }
}