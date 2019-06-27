namespace exceptionhandeling
{
    class exceptionHandeling
    {
        static void Main(string[] arg)
        {
            int[] numbers = {1,2,3,4,5};
            try
            {
                for(int i = 0; i<numbers.Length;i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            
            catch(ArugumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                numbers = null;
            }

        }
        
    }
}