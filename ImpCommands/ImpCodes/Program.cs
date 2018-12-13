using System;

namespace ImpCodes
{
    class Program
    {
        static void Main( string[] args )
        {
            //YeildCommand obj = new YeildCommand();

            //obj.fillMyList();

            //foreach(int i in obj.MyList)
            //{
            //    Console.WriteLine(i); 
            //}

            //foreach(int i in obj.filter())
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("yield");
            //foreach (int i in obj.filterYield())
            //{
            //    Console.WriteLine(i);
            //}

            GetEmployee ge = new GetEmployee();
            ge.fillEmployees();
            ge.getEmp();

            Console.ReadLine();
        }
    }
}
