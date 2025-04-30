namespace arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string separator = "--------------------------------";
            //Declaração de Arrays inciando com valores.
            string[] fruits = { "Maça", "Banana", "Caju", "Manga" };


            Console.WriteLine(fruits[0]);


            Console.WriteLine(separator);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //Contagem de indices.
            // Length tag para  tamanho ou quantidade.

            Console.WriteLine(separator);


            Console.WriteLine("Quantidade de indices: " + fruits.Length);

            //Alterar os valores dos indices.

            Console.WriteLine(separator);

            Console.WriteLine("Valor antes da alteração " + fruits[1]);
            fruits[1] = "Pera";
            Console.WriteLine("Valor antes da alteração " + fruits[1]);

            Console.WriteLine(separator);
            //Declaração sem inicializar.
            //Arrays sem incializar é obrigado colocar a quantidade de indices o arrays terá.
            int[] numbers = new int[3];
            numbers[0] = 7;
            numbers[1] = 8; 
            numbers[2] = 19;

            foreach (int number  in numbers)
            {
                Console.WriteLine(number);
            }






        }
    }
}