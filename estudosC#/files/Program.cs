namespace files;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        ////1- Criar um arquivo.
        //string content = "Hello World";
        //System.IO.File.WriteAllText("file.txt",content );

        //Console.WriteLine("Arquivo criado com sucesso");

        //2- Criar arquivo em local especifico.

        //string path = @"D:\C#\files/filesName.txt";
        //string content = "Hello World";
        //File.WriteAllText(path, content);

        //Console.WriteLine("Arquivo criado com sucesso");

        //3- Criar um arquivo Word.

        //string path = @"D:\C#\files\";
        //string fileName = "myDocument.Doc";
        //string filePath = path + fileName;

        //string content = "Hello World";

        //File.WriteAllText(filePath, content);

        //Console.WriteLine("Arquivo word criado com sucesso");

        //4- Inserir um paragrafo em um arquivo.

        //string path = @"D:\C#\files\";
        //string fileName = "myDocument.Doc";
        //string filePath = path + fileName;

        //string adtionalContent = "|||Aulas de Csharp e .Net";
        //File.AppendAllText(filePath, adtionalContent);

        //Console.WriteLine("Arquivo atualizado com sucesso");

        //5- Ler o arquivo.
        string path = @"D:\C#\files\";
        string fileName = "myDocument.Doc";
        string filePath = path + fileName;

        string adtionalContent = "|||Aulas de Csharp e .Net";
        File.AppendAllText(filePath, adtionalContent);

        Console.WriteLine("Arquivo atualizado com sucesso");
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);






    }
}