namespace exceptionhandeling
{
    class exceptionHandeling
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("enter first number");
            int num1 = (int)Console.ReadLine();
            Console.WriteLine("enter second number");
            int num2 = (int)Console.ReadLine();
            
            try
            {
                int result = num1/num2;
                Console.WriteLine(result); 
            }
            
            catch(ArugumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(DivideByZeroExceptio ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                num1 = 0;
                num2 = 0;
            }

        }
        
    }
}