using System.Collections;

namespace collections
{
    public class ArrayListClass
    {
        public ArrayList arr = new ArrayList(); //create an object to access this Array
        public static void Main()
        {
            ArrayListClass obj = new ArrayListClass(); //creating the object for the "ArrayListClass" to access the arraylist
            obj.arr1[0]=1; //adding element to the array at position 0
            obj.arr1[1]=2; //adding element to the array at position 1
            obj.arr[2]="Mukundh";

            //creating the array in static method
            ArrayList arr2 = new ArrayList(); //No access sepcifier when declared in main
            arr2.Add(1);
            arr2.Add(3);            
            arr2.Add("Mukundh");
            Console.WriteLine(arr2.capacity); //tell the amount of items it can hold per add. It starts with 0. 
            //After adding an element it increases to 4 and doesnot increase until all the 4 places are filled
            
            //Printing the list
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}