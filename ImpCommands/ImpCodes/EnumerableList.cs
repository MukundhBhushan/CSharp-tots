using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImpCodes
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }


    }

    class GetEmployee
    {
        List<Employee> Employees = new List<Employee>();

        public void fillEmployees()
        {
            Employees.Add(new Employee { ID = 1,Job="CEO",Name="Mukundh",Salary=1000000 });
            Employees.Add(new Employee { ID = 2, Job = "Developer", Name = "Mukundh", Salary = 100000 });
            Employees.Add(new Employee { ID = 3, Job = "Data Analyst", Name = "Mukundh", Salary = 50000 });
            Employees.Add(new Employee { ID = 4, Job = "CTO", Name = "Mukundh", Salary = 500000 });


        }

        public void getEmp()
        {
            foreach(Employee i in Employees)
            {
                Console.WriteLine($"{i.ID},{i.Name}");
            }
        }
    }

}
