using System;



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
            Console.WriteLine("");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("");
            Console.WriteLine("5 - PORCETAGEM");
            Console.WriteLine("");
            Console.WriteLine("6 - POTENCIAÇÃO");
            Console.WriteLine("");
            Console.WriteLine("7 - SENO COSSENO TANGENTE");
            Console.WriteLine("");
            Console.WriteLine("8 - PORCETAGEM");
            Console.WriteLine("");
            Console.WriteLine("10 - SAIR DA APLIACAÇÃO");

            short key = short.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Multiplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 5:
                    Porcetagem();
                    break;

                case 6:
                    Potenciacao();
                    break;

                case 7:
                    SenoCossenoTangente();
                    break;

                case 10:
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("SOMA");
            Console.WriteLine("Coloque o Primeiro Valor");

            var valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o Segundo Valor");

            var valor2 = float.Parse(Console.ReadLine());

            var resultado = valor1 + valor2;

            Console.WriteLine($"O Resultado da SOMA é: {resultado}");
            Continuar();
        }

        static void Subtracao()
        {
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Coloque Primeiro Valor");

            var valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o Segundo Valor");

            var valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da SUBTRAÇÃO é: {valor1 - valor2}");
            Continuar();        
        }

        static void Multiplicacao()
        {

            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Coloque Primeiro Valor");

            var valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque Segundo Valor");

            var valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da MULTIPLICAÇÃO é: {valor1 * valor2}");
            Continuar();
        }

        static void Divisao()
        {
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Coloque Primeiro Valor");

            var valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque Segundo Valor");

            var valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resuldado da DIVISÃO é : {valor1 / valor2}");
            Continuar();
        }

        static void Porcetagem()
        {
            Console.WriteLine("PORCETAGEM");
            Console.WriteLine("Coloque o Primeiro Valor");

            var valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Quantos PORCENTOS de {valor1}");

            var valor2 = float.Parse(Console.ReadLine());

            var resultado = (valor2/ 100) * valor1;
            Console.WriteLine($"O Resultado da PORCETAGEM é: {resultado}");
            Continuar();
        }

        static void Potenciacao()
        {
        Console.WriteLine("POTENCIAÇÃO");
        Console.WriteLine("Coloque o Primeiro Valor");

        var valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Coloque o Segundo Valor");

        var valor2 = Convert.ToDouble(Console.ReadLine());

        var resultado = Math.Pow(valor1, valor2);

        Console.WriteLine($"O Resultado da POTENCIAÇÃO é: {resultado}");
        Continuar();
        }

        static void SenoCossenoTangente()
        {
            Console.WriteLine("SENO COSENO TANGENTE");

            double angulo;

            Console.WriteLine("Coloque qual o ângulo em °: ");
            angulo = double.Parse(Console.ReadLine());

            var seno = Math.Sin(angulo * (Math.PI / 180));
            var cosseno = Math.Cos(angulo * (Math.PI / 180));
            var tangente = Math.Tan(angulo * (Math.PI / 180));

            Console.WriteLine($"O SENO de {angulo}° é: {Math.Round(seno, 3)}");
            Console.WriteLine($"O COSSENO de {angulo}° é: {Math.Round(cosseno, 3)}");
            Console.WriteLine($"O TANGENTE de {angulo}° é: {Math.Round(tangente, 3)}");

            Continuar();
        }

        static void Continuar()
        {
            Console.WriteLine("Deseja continuar: ");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            var resposta = Console.ReadLine();

            if (resposta == "1")
            {
                Menu();
            }

            else
            {
                System.Environment.Exit(0);
            }

        }

    }
}
