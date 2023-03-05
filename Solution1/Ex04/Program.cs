using System;

namespace ImprimeConsoantes
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto, consoantes;

            Console.Write("Digite um texto: ");
            texto = Console.ReadLine();

            consoantes = GetConsoantes(texto);

            Console.WriteLine("As consoantes presentes no texto são: " + consoantes);
            Console.ReadKey();
        }

        // Função que retorna uma string contendo apenas as consoantes de uma outra string
        static string GetConsoantes(string texto)
        {
            string consoantes = "";

            // Percorrer a string e verificar cada caractere
            foreach (char c in texto)
            {
                if (IsConsoante(c))
                {
                    consoantes += c;
                }
            }

            return consoantes;
        }

        // Função que verifica se um caractere é uma consoante
        static bool IsConsoante(char c)
        {
            // Verificar se o caractere é uma letra
            if (!Char.IsLetter(c))
            {
                return false;
            }

            // Verificar se o caractere é uma vogal
            if ("AEIOUaeiou".Contains(c.ToString()))
            {
                return false;
            }

            return true;
        }
    }
}

