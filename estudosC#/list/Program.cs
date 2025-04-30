namespace listt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string separator = "----------------------------------------";


            //1- Declaração com inicialização de valores.
            List<string> fruits = new List<string>()
            {
                "Manga",
                "Maçã",
                "Uva"

            };

            //2- Acessar os valores.
            Console.WriteLine(fruits[2]);

            Console.WriteLine(separator);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //3- Adicionar elementos.

            fruits.Add("Abacate");
            fruits.Add("Graviola");

            Console.WriteLine(separator);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //4- Remover elementos.
            fruits.Remove("Maçã");

            Console.WriteLine(separator);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //5- Contagem de elementos.
            //Tag "Count" usada para contar quantidade de indices dentro da lista.

            Console.WriteLine(separator);

            Console.WriteLine("Quantidade de frutas: " + fruits.Count);

            Console.WriteLine(separator);

            //6- Modificar elementos.

            fruits[3] = "Laranja";

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //7- Limpar a lista.

            fruits.Clear();

            Console.WriteLine(separator);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //8- Declarar sem inicializar.

            Console.WriteLine(separator);

            List<int> numbers = new List<int>();


            numbers.Add(1);
            numbers.Add(32);
            numbers.Add(7);
            numbers.Add(8);

            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }



        }
    }
}