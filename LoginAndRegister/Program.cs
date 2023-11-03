using System;
using System.Collections.Generic;

namespace LoginAndRegister
{
    class Program
    {

        public static Dictionary<string, string> credentials = new Dictionary<string, string>();

        static void Main(string[] args)
        {

            credentials.Add("root", "");

            bool hasSuccessfulLogin = false;

            Console.WriteLine("Você já tem um registro no aplicativo? (s/n):");
            bool HasPreLogin = (Console.ReadLine() == "s" ? true : false);

            while (!hasSuccessfulLogin)
            {
                if (HasPreLogin)
                {
                    Console.WriteLine("Dígite o nome de usuário:");
                    string user = Console.ReadLine();

                    Console.WriteLine("Dígite a password de " + user + ":");
                    string password = Console.ReadLine();

                    if (credentials.ContainsKey(user) && credentials[user] == password)
                    {
                        Console.WriteLine("Acesso garantido! Enviando para o programa...");
                        hasSuccessfulLogin = true;
                    }
                    else
                    {
                        Console.WriteLine("Você inseriu dados errados ou não existem. Tente fazer login novamente!");
                    }
                }
                else
                {
                    Console.WriteLine("Dígite o nome de usuário para registro:");
                    string newUser = Console.ReadLine();

                    if (credentials.ContainsKey(newUser))
                    {
                        Console.WriteLine("Esse nome de usuário já existe, tente novamente!");
                    }
                    else
                    {
                        Console.WriteLine("Dígite a password de " + newUser + " para registro:");
                        string newPassword = Console.ReadLine();

                        credentials.Add(newUser, newPassword);
                        HasPreLogin = true;

                        Console.WriteLine("Registro concluido, volte e faça login!");
                    }
                }
            }
        }

    }
}
