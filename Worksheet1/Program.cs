namespace Worksheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntergersFor();
            Console.WriteLine();
            PrintIntergersWhile();
            Console.WriteLine();
            PrintIntergersDo();
            Console.WriteLine();
            PrintExcludingFor();
            Console.WriteLine();
            PrintDescendingFor();
        }



        static private void PrintIntergersFor()
        {
            
           
            for(int i = 40; i <= 60; i++)
            {
                Console.WriteLine($"Intergers between 40 and 60 are {i}");
                
            }
        }

        static private void PrintIntergersWhile()
        {
            
            int x= 0;
            while (x >= 40 && x<=60)
            {
                Console.WriteLine($"The intergers between 40 and 60 are {x}");
                x++;
            }
        }
        static private void PrintIntergersDo()
        {
            int x = 40;
            do
            {
                Console.WriteLine($"All intergers between 40 and 60 are {x}");
                x = x + 1;
            }
            while (x <= 60);
        }
        private static void PrintExcludingFor()
        {
            for(int i = 40; i <= 60; i++)
            {
               /* if(i == 46 || i == 48)
                {
                    Console.WriteLine("");

                    else
                        Console.WriteLine(i);
                }*/
                
            }
        }
        private static void PrintDescendingFor()
        {
            for(int y = 60; y >=40; y--) 
            Console.WriteLine(y);
        }



    }
}