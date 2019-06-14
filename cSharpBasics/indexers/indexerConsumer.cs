using System;

namespace Indexer 
{
    public class IndexerConsumer
    {
        public static void Main()
        {
            Employee emp = new Employee(1,200000,"Mukundh","CEO","Business","earth");
            //get
                Console.WriteLine($"Empno {emp[0]}");
                Console.WriteLine($"Empno {emp["EmpNo"]}");
                
                Console.WriteLine($"salary {emp[1]}");
                Console.WriteLine($"salary {emp["salary"]}");

                Console.WriteLine($"EmpName {emp[2]}");
                Console.WriteLine($"EmpName {emp["EmpName"]}");

                Console.WriteLine($"Job {emp[3]}");
                Console.WriteLine($"Job {emp["Job"]}");

                Console.WriteLine($"DeptName {emp[4]}");
                Console.WriteLine($"DeptName {emp["DeptName"]}");

                Console.WriteLine($"Location {emp[5]}");
                Console.WriteLine($"Location {emp["Location"]}");
            //set
                emp[1]=1000000;
                emp[4]="dev";
        }
    }
    
}