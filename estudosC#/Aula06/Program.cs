namespace Aula06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----- Verficadores de numeros pares ou impares");
            Console.WriteLine("Digite um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(" O numero " + number + " e Par");
            }

            else
            {
                Console.WriteLine("O numero " + number + " e Impar");
            }

        }
    }
}