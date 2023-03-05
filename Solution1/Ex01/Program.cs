using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            string operacao;

            Console.WriteLine("Bem-vindo à calculadora!");

            // Pedir ao usuário que digite os números e a operação
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação desejada (+, -, *, /, %): ");
            operacao = Console.ReadLine();

            // Verificar qual operação o usuário escolheu e realizar o cálculo
            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    break;

                case "%":
                    resultado = num1 % num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("Obrigado por utilizar a calculadora. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
