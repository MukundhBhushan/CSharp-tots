using System;

namespace cSharpBasic
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name {get;set;}
        public int Salary { get; set; }
        public string City { get; set; }
        
    }
    
    class Program
    {

        List<Employee> EmpList = new List<Employee>();

        Employee emp1 = new Employee()
        {
            EmpId = 0001,
            Name = "Emp1",
            Salary = 10000,
            City = "blore"
        };

        EmpList.Add(emp1);

        Employee emp2 = new Employee()
        {
            EmpId = 0002,
            Name = "Emp2",
            Salary = 20000,
            City = "blore"
        };

        EmpList.Add(emp2);

        Employee emp3 = new Employee()
        {
            EmpId = 0003,
            Name = "Emp3",
            Salary = 30000,
            City = "blore"
        };
        
        EmpList.Add(emp3);

        Employee emp4 = new Employee()
        {
            EmpId = 0004,
            Name = "Emp4",
            Salary = 40000,
            City = "blore"
        };

        EmpList.Add(emp4);

        var result = EmpList.Where(emp => emp.Salary >= 5000).OrderbyId(emp => emp.EmpId) //In the current eg the records are in order so "OrderBy is not needed"

        foreach (var item in result)
        {
            System.Console.WriteLine($"EmpId:{item.EmpId} \t Name: {item.Name}");
        }

        var result = EmpList.Where(emp => emp.Name.StratsWith('E'));` 

        foreach (var item in result)
        {
            System.Console.WriteLine($"EmpId: {item.EmpId} \t Name: {item.Name}");
        }

    }
}
