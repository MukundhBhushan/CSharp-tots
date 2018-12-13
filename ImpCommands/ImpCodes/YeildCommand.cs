using System;
using System.Collections.Generic;
using System.Text;

namespace ImpCodes
{
    class YeildCommand
    {
        //yeild is used to remove the need of temp var being returned as the function output\

        public List<int> MyList = new List<int>();
        
        public void fillMyList()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }

        //function without yeild to filter the numbers greater than 3
         public IEnumerable<int> filter()
        {
            List<int> temp = new List<int>();
            
            foreach(int i in MyList)
            {
                if(i>3)
                {
                    temp.Add(i);
                }
            }
            return (temp);
        }


        //the same above function with yeild doesnot require the var temp it can directly be returned
        public IEnumerable<int> filterYield()
        {
            foreach(int i in MyList)
            {
                if(i>3)
                {
                    yield return i;
                }
            }
               
        }


    }
}
