namespace foor 
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            /* Condição 1 é executada(uma unica vez) antes da execução do bloco de código.
             * Condição 2 define a condição para ser executada p bloco de código.
               Condição 3 é executada (todas as vezes) após o bloco de codigos ter sido executado
             
            // */
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("------Tabela de Multiplicação");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,6}");
                }


            }
        
        }
    }
}