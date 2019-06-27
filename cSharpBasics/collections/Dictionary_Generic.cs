using System.Collections;

namespace collections
{
    public class DictionaryClass
    {
        public Dictionary<int,string> arr = new Dictionary<int,string>(); //create an object to access this Array
        public static void Main()
        {
            DictionaryClass obj = new DictionaryClass(); //creating the object for the "ArrayListClass" to access the arraylist
            obj.arr.Add("<key>","<string value>");
            obj.arr.Add(1,"Mukundh");
            obj.arr.Add(2,"Bhushan");
            obj.arr.Add(3,"123");
            //Non genric stack ie different data types
            Dictionary<int,string> arr2 = new Dictionary<int,string>();//No access sepcifier when declared in main
            arr2.Add("<key>","<value>");
            arr2.Add(1,"Mukundh");
            arr2.Add(2,"Bhushan");
            arr2.Add(3,"123");

            //Printing the hashtable
            foreach (var item in arr2)
            {
                Console.WriteLine($"{item.Key} \t {item.Value}");
                // if "key" and "valule" are not mentioned then "DiciionaryEntry" would get printed not the keys and values
            }
        }
    }
}