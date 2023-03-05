using System;

namespace ImprimeVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto, vogais;

            Console.Write("Digite um texto: ");
            texto = Console.ReadLine();

            vogais = GetVogais(texto);

            Console.WriteLine("As vogais presentes no texto são: " + vogais);
            Console.ReadKey();
        }

        // Função que retorna uma string contendo apenas as vogais de uma outra string
        static string GetVogais(string texto)
        {
            string vogais = "";

            // Percorrer a string e verificar cada caractere
            foreach (char c in texto)
            {
                if (IsVogal(c))
                {
                    vogais += c;
                }
            }

            return vogais;
        }

        // Função que verifica se um caractere é uma vogal
        static bool IsVogal(char c)
        {
            return "AEIOUaeiou".Contains(c.ToString());
        }
    }
}
