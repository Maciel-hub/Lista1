using System;

namespace ContagemVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            int contVogais = 0;
            string texto;

            Console.Write("Digite um texto: ");
            texto = Console.ReadLine();

            // Percorrer a string e verificar cada caractere
            foreach (char c in texto)
            {
                if (IsVogal(c))
                {
                    contVogais++;
                }
            }

            Console.WriteLine("O texto digitado possui " + contVogais + " vogais.");
            Console.ReadKey();
        }

        // Função que verifica se um caractere é uma vogal
        static bool IsVogal(char c)
        {
            return "AEIOUaeiou".Contains(c.ToString());
        }
    }
}
