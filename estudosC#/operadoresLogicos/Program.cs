namespace operadores_Logicos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Operadores Logicos");

            bool isLogged = true;
            bool hasAminAcess = false;



            Console.WriteLine("\nInformações do Usuário: ");
            Console.WriteLine("Usuario logado: " + isLogged);
            Console.WriteLine("Acesso ao painel de administrador " + hasAminAcess);

            Console.WriteLine("\nPermissões:");

            if (isLogged || hasAminAcess)
            {
                Console.WriteLine("Acesso ao sistema concedido! ");
            }
            else
            {
                Console.WriteLine("Acesso ao sistema negado!");
            }

            if (isLogged && hasAminAcess)
            {
                Console.WriteLine("Acesso ao painel de administrador concedido");
            }
            else
            {
                Console.WriteLine("Acesso ao painel de adminstrador negado!");
            }

            //Operador de negação

            if (!isLogged)
            {
                Console.WriteLine("Usuário não está logado");
            }
            else
            {
                Console.WriteLine("Usuário está logado");
            }




        }
    }
}