using System;

namespace cSharpBasic
{
    class ThreadClass
    {
        public static void Method1()
        {
            for(int i =0; i<10;i++)
            {
                System.Console.WriteLine("Method 1");
                Thread.sleep(600); //in ms
            }
        }

        public static void Method2()
        {
            for(int i =0; i<10;i++)
            {
                System.Console.WriteLine("Method 2");
                Thread.sleep(600);
            }
        }

        public void Method3()
        {
            for(int i =0; i<10;i++)
            {
                System.Console.WriteLine("Method 3");
                Thread.sleep(600); //in ms
            }
        }

        public void Method4()
        {
            for(int i =0; i<10;i++)
            {
                System.Console.WriteLine("Method 4");
                Thread.sleep(600);
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);

            ThreadClass obj = new ThreadClass();

            Thread thread3 = new Thread(obj.Method3);
            Thread thread4 = new Thread(obj.Method4);

            thread1.Start();            
            thread2.Start();            
            thread3.Start();            
            thread4.Start();            

        }
    }
}
