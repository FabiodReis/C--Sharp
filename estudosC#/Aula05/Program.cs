namespace Aula05
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("======== Calculadora simples=========");
            Console.WriteLine("Digite o Primeiro Numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            int module = number1 % number2;


            Console.WriteLine("A soma dos numeros e: " + sum);
            Console.WriteLine("A subtracao dos numeros e: " + subtraction);
            Console.WriteLine("A multiplicacao dos numeros e: " + multiplication);
            Console.WriteLine("A Divisao dos numeros e: " + division);
            Console.WriteLine("O resto da divsao dos numeros e: " + module);
        }

    }

}
