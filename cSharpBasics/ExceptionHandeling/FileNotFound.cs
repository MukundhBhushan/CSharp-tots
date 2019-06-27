namespace exceptionhandeling
{
    class exceptionHandeling
    {
        static void Main(string[] arg)
        {
            try
            {
                File.OpenRead("/<some random path>");

            }
            
            catch(FileNotFoundException ex)
            {
                try
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }

        }
        
    }
}