namespace calculadora_If_Else
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool varContinue = true;

            while (varContinue)

            {

                Console.WriteLine("\n------calculadora_If_Else------\n");

                Console.WriteLine("Digite o Primeiro numero: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Segundo numero: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                //Selecionar o tipo de operação
                Console.WriteLine("\nEscolha uma operação");
                Console.WriteLine("1- Adição (+)z\n");
                Console.WriteLine("2- Subtração (-)\n");
                Console.WriteLine("3- Multiplicação (*)\n");
                Console.WriteLine("4- Divisão (/)");
                Console.WriteLine("Digite o numero da operação");
                int operation = Convert.ToInt32(Console.ReadLine());




                if (operation == 1)
                {
                    Console.WriteLine("A soma dos numeros é: " + (n1 + n2));

                }
                else if (operation == 2)
                {
                    Console.WriteLine("A subtraçao dos numeros é: " + (n1 - n2));

                }
                else if (operation == 3)
                {
                    Console.WriteLine("A multiplicação dos numeros é: " + (n1 * n2));

                }
                else if (operation == 4)
                {
                    if (n1 != 0 && n2 != 0)
                    {
                        Console.WriteLine("A divisão dos numeros é:" + (n1 / n2));
                    }

                    else
                    {
                        Console.WriteLine("Erro: Não é possivel dividir um numero por 0!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Operação Invalida!!");

                }

                Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
                String response = Console.ReadLine();

                if (response != "s")
                { varContinue = false; }


            }

            Console.WriteLine("\nObrigado por usar a calculadora");

        }
    }
}