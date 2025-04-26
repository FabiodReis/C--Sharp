namespace Aula04;
public class Program{
    public static void Main()
    {
        Console.WriteLine("-------CADASTRO DE USUARIO________");
        // Solicitar o nome do usuario
        Console.WriteLine("Digite seu nome: ");
        //Usar Console.ReadLine e o (Scanner) do C#
        string name = Console.ReadLine();
        

        //Solicitar a idade do usuario
        Console.WriteLine("Digite sus idade: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nome do Usuario: " + name);
        Console.WriteLine("Idade do usuario: " + age);

    }

}