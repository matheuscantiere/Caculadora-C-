using System;

class Program
{
    static void Main()
    {
        int Opcao = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.Write("\nOpção: ");
            Opcao = Convert.ToInt32(Console.ReadLine());

            if (Opcao >= 1 && Opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double Numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double Numero2 = Convert.ToDouble(Console.ReadLine());

                double Resultado = 0;

                switch (Opcao)
                {
                    case 1:
                        Resultado = Numero1 + Numero2;
                        Console.WriteLine($"\nResultado: {Resultado}");
                        break;

                    case 2:
                        Resultado = Numero1 - Numero2;
                        Console.WriteLine($"\nResultado: {Resultado}");
                        break;

                    case 3:
                        Resultado = Numero1 * Numero2;
                        Console.WriteLine($"\nResultado: {Resultado}");
                        break;

                    case 4:
                        if (Numero2 == 0)
                        {
                            Console.WriteLine("\nErro: divisão por zero não é permitida.");
                        }
                        else
                        {
                            Resultado = Numero1 / Numero2;
                            Console.WriteLine($"\nResultado: {Resultado}");
                        }
                        break;
                }
            }
            else if (Opcao != 5)
            {
                Console.WriteLine("\nOpção inválida!");
            }

            if (Opcao != 5)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (Opcao != 5);

        Console.WriteLine("\nPrograma encerrado.");
    }
}