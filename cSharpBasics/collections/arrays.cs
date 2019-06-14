namespace collections
{
    public class ArrayArrayClass
    {
        public int[] arr1 = new int[5]; //create an object to access this Array
        public static void Main()
        {
            ArrayClass obj = new ArrayClass(); //creating the object to access the array
            obj.arr1[0]=1; //adding element to the array at position 0
            obj.arr1[1]=2; //adding element to the array at position 1

            //creating the array in static method
            int[] arr = new int[5]; //No access sepcifier when declared in main
            arr[0] = 1;
            arr[1]=2;

            int [,] arrmul = new int[5,6]; //creating a multi dim array
            arrmul[0,0]=12;
            arrmul[0,1]=13;
        }
    }
}