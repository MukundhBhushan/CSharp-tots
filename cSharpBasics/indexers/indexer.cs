using System;
using System.Collections.Generic;
using System.Collections;

namespace Indexer
{
    public class Employee
    {
        int EmpNO;
        double salary;
        string EmpName,Job,DeptName,Location;

        public Employee(int EmpNO,double salary,string EmpName,string Job,string DeptName,string Location)
        {
            this.EmpNO =EmpNO;
            this.salary=salary;
            this.EmpName = EmpName;
            this.Job =  Job;
            this.DeptName =  DeptName;
            this.Location = Location;

        }

    //first with indexes
        public object this[int index]
        {
            get
            {
                if(index==0)
                    return EmpNO;
                else if(index==1)
                    return salary;
                else if(index==2)
                    return EmpName;
                else if(index==3)
                    return Job;
                else if(index==4)
                    return DeptName;
                else if(index==5)
                    return Location;
                return null;
            }

            //second way then first
            

            set
            {
                if(index==0)
                    EmpNO = (int)value;
                else if(index==1)
                    salary = (int)value;
                else if(index==2)
                    EmpName = (string)value;
                else if(index==3)
                    Job = (string)value;
                else if(index==4)
                    DeptName = (string)value;
                else if(index==5)
                    Location = (string)value;
                return null;
            }
        }

    //second way with property name
        public object this[string name]
        {
            get{
                if(index=="EmpNo")
                    return EmpNO;
                else if(index=="salary")
                    return salary;
                else if(index=="EmpName")
                    return EmpName;
                else if(index=="Job")
                    return Job;
                else if(index=="DeptName")
                    return DeptName;
                else if(index=="Location")
                    return Location;
                return null;
            }

            set
            {
                if(index=="EmpNo")
                    EmpNO = (int)value;
                else if(index=="salary")
                    salary = (int)value;
                else if(index=="EmpName")
                    EmpName = (string)value;
                else if(index=="Job")
                    Job = (string)value;
                else if(index=="DeptName")
                    DeptName = (string)value;
                else if(index=="Location")
                    Location = (string)value;
                return null;
            }
        }
    

    }

}
