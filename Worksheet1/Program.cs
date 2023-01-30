namespace Worksheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntergersFor();
            PrintIntergersWhile();
        }



        static private void PrintIntergersFor()
        {
            int a = 40;
            int b = 60;
          
            for(int i = 0; i <=a && i >= b; i++)
            {
                Console.WriteLine($"Intergers between 40 and 60 are {i}");
            }
        }

        static private void PrintIntergersWhile()
        {

        }
    }
}