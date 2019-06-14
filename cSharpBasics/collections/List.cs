namespace collections
{
    public class ListClass
    {
        public List<int> list = new List<int>(); //create an object to access this list
        public static void Main()
        {
            ListClass obj = new ListClass(); //creating the object to access the array
            obj.list.Add(1); //adding element to the list 
            obj.list.Add(2); //adding element to the array at position 1

            //creating the array in static method
            List<int> listMain = new List<int>(); //No access sepcifier when declared in main
            listMain.Add(1);
            listMain.Add(2);

        }
    }
}