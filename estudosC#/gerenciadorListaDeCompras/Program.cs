namespace gerenciadorListaDeCompras;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        //1- Estrutura.
        string path = @"D:\C#\gerenciadorListaDeCompras\";
        string fileName = "Lista_de_Compras";
        string filePath = path + fileName;

        List<string> shoopingList = new List<string>();

        //2- Logica.

        if (File.Exists(filePath))
        {
            shoopingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n------Lista de Compra\n");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir Lista");
            Console.WriteLine("4. Limpar a lista ");
            Console.WriteLine("5. Exporta lista\n");
            Console.WriteLine(" Escolha um numero para continuar! \n");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item que você quer adicionado: ");
                    string itemInser = Console.ReadLine();
                    if (!String.IsNullOrEmpty(itemInser))
                    {
                        shoopingList.Add(itemInser);
                        Console.WriteLine($"Item '{itemInser}'adicionado com sucesso\n");

                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio\n");

                    }
                    break;
                case "2":
                    Console.WriteLine("Digite o nome do item para remover");
                    string itemToRemove = Console.ReadLine();
                    if (shoopingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Item '{itemToRemove}' removido com sucesso!\n");
                    }
                    else
                    {
                        Console.WriteLine("Item não encontrado!\n");
                    }


                    break;

                case "3":
                    Console.WriteLine("Itens na sua lista de compra\n");
                    if (shoopingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista esta vazia\n");
                    }
                    else
                    {
                        for (int i = 0; i < shoopingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoopingList[i]}");
                        }
                    }
                    break;
                case "4":
                    shoopingList.Clear();
                    break;


                case "5":
                    File.WriteAllLines(filePath, shoopingList);
                    Console.WriteLine("Lista Salva com sucesso! Saindo...\n");
                    return;

                default:
                    Console.WriteLine("Opção Invalida, tente novamente\n");
                    break;
            }

        }






    }

}




