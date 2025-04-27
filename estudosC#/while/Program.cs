namespace loopWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int i = 0;

            //while (i <= 5) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} 

            double budget = 100;

            while (budget > 0) 
            {
                Console.WriteLine(budget);
                budget--;
            }

            Console.WriteLine("Saldo insuficiente");
        }
    }
}