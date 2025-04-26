namespace operadoresDeAtribuicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Operadores de Atribuicao");
            Console.WriteLine("Operadores Simples");
            Console.WriteLine("\n Atribuicao simples (=)");
            Console.WriteLine("Valor de x: " + x);

            // Isso e a mesma coisa de x = x + 1;
            x++;

            Console.WriteLine("\n Atribuicao composta de Incremento");
            Console.WriteLine("Novo valor de x: " + x);

            x += 10;
            Console.WriteLine("\n Atribuicao composta ");
            Console.WriteLine("Novo valor de x: " + x);




        }
    }
}