using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione sua Operação");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - PORCETAGEM");
            Console.WriteLine("6 - POTENCIAÇÃO");
            Console.WriteLine("7 - SAIR DA APLIACAÇÃO");
            short key = short.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    soma();
                    break;

                case 2:
                    subtracao();
                    break;

                case 3:
                    multiplicacao();
                    break;

                case 4:
                    divisao();
                    break;

                case 5:
                    porcetagem();
                    break;

                case 6:
                    potenciacao();
                    break;

                case 7:
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void soma()
        {
            Console.WriteLine("SOMA");
            Console.WriteLine("Coloque o Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());
            var resultado = valor1 + valor2;
            Console.WriteLine($"O Resultado da SOMA é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void subtracao()
        {
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Coloque Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O Resultado da SUBTRAÇÃO é: {valor1 - valor2}");
            Console.ReadKey();
            Menu();
        }

        static void multiplicacao()
        {

            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Coloque Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Coloque Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O Resultado da MULTIPLICAÇÃO é: {valor1 * valor2}");
            Console.ReadKey();
            Menu();
        }

        static void divisao()
        {
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Coloque Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Coloque Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O Resuldado da DIVISÃO é : {valor1 / valor2}");
            Console.ReadKey();
            Menu();
        }

        static void porcetagem()
        {
            Console.WriteLine("PORCETAGEM");
            Console.WriteLine("Coloque o Primeiro Valor");
            var valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Quantos PORCENTOS de {valor1}");
            var valor2 = float.Parse(Console.ReadLine());
            var resultado = (valor2/ 100) * valor1;
            Console.WriteLine($"O Resultado da PORCETAGEM é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void potenciacao()
        {
        Console.WriteLine("POTENCIAÇÃO");
        Console.WriteLine("Coloque o Primeiro Valor");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Coloque o Segundo Valor");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        double resultado = Math.Pow(valor1, valor2);
        Console.WriteLine($"O Resultado da POTENCIAÇÃO é: {resultado}");
        Console.ReadKey();
        Menu();
        }

    }
}
