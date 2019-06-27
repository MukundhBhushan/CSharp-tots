using System.Collections;

namespace collections
{
    public class HashtableClass
    {
        public Hashtable arr = new Hashtable(); //create an object to access this Array
        public static void Main()
        {
            HashtableClass obj = new HashtableClass(); //creating the object for the "ArrayListClass" to access the arraylist
            obj.arr.Add("<key>","<value>");
            obj.arr.Add(1,"Mukundh");
            obj.arr.Add(2,"Bhushan");
            obj.arr.Add(3,123);
            //Non genric stack ie different data types
            Hashtable arr2 = new Hashtable(); //No access sepcifier when declared in main
            arr2.Add("<key>","<value>");
            arr2.Add(1,"Mukundh");
            arr2.Add(2,"Bhushan");
            arr2.Add(3,123);

            //Printing the hashtable
            foreach (var item in arr2)
            {
                Console.WriteLine($"{item.Key} \t {item.Value}");
                // if "key" and "valule" are not mentioned then "DiciionaryEntry" would get printed not the keys and values
            }
        }
    }
}