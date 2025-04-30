namespace foreachh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Foreach é usado com (coleções)listas

            List<int> numberList = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //para cada item
            foreach (int number in numberList) 
            {
                //Faça algo
                Console.WriteLine(number);

            }


        }

    }
}