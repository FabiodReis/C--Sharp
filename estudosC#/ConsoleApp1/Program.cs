namespace swite_Case
{
    public class Program
    {
        public static void Main(string[] args)



        {

            //    Console.WriteLine("----- Dia da Semana");

            //    Console.WriteLine("Digite um número de 1 a 7");

            //    int dayOfWeek = (Convert.ToInt32(Console.ReadLine()));

            //    switch (dayOfWeek)
            //    {
            //        case 1:
            //            Console.WriteLine("O dia da semana é Segunda-Feira");
            //            break;
            //        case 2:
            //            Console.WriteLine("O dia da semana é Terça-Feira");
            //            break;
            //        case 3:
            //            Console.WriteLine("O dia da semana é Quarta-Feira");
            //            break;
            //        case 4:
            //            Console.WriteLine("O dia da semana é Quinta-Feira");
            //            break;
            //        case 5:
            //            Console.WriteLine("O dia da semana é Sexta-Feira");
            //            break;
            //        case 6:
            //            Console.WriteLine("O dia da semana é Sábado");
            //            break;
            //        case 7:
            //            Console.WriteLine("O dia da semana é Doming");
            //            break;

            //        default:
            //            Console.WriteLine("Numero invalido");
            //            break;



            Console.WriteLine("-------Desempenho Escolar------ -");
            Console.WriteLine("Digite sua nota: ");

            int score = Convert.ToInt32(Console.ReadLine());

            switch (score)
            {
                case 10:
                case 9:
                    Console.WriteLine("Otimo");
                    break;

                case 8:
                case 7:
                    Console.WriteLine("Bom");
                    break;

                case 6:
                case 5:
                    Console.WriteLine("Regular");
                    break;
                default:
                    Console.WriteLine("Ruim");
                    break;

            }





        }





    }
}


