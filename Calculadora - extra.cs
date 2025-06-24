using System;

class Program
{
    public static void Main(string[] args)
    {

        // Console.Read() -> lê um caractere apenas
        // Console.ReadLine() -> lê a linha até receber um enter

        int op;

        do
        {
            Console.WriteLine("Digite qual operação deseja realizar:");
            Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Resto\n6 - Potência\n0 - Sair");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("\nDigite o primeiro valor: ");
                    int sum1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo valor: ");
                    int sum2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\n{sum1} + {sum2} = {sum1 + sum2}\n");

                    break;
                case 2:

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    int sub1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo valor: ");
                    int sub2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\n{sub1} - {sub2} = {sub1 - sub2}\n");

                    break;
                case 3:

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    int mut1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo valor: ");
                    int mut2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\n{mut1} x {mut2} = {mut1 * mut2}\n");

                    break;
                case 4:

                    // Os dois valores tem que ser double, quando testado com int, o resultado era zero
                    Console.WriteLine("\nDigite o primeiro valor: ");
                    double div1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo valor: ");
                    double div2 = Convert.ToDouble(Console.ReadLine());

                    if (div2 == 0.0)
                    {
                        Console.WriteLine("Erro ao gerar divisão por zero, tente novamente");
                        op = 4;
                    }
                    else
                    {
                        // Nem mesmo por (float) antes da operação deu certo
                        Console.WriteLine($"\n{div1} / {div2} = {div1 / div2}\n");
                    }

                    break;
                case 5:
                    Console.WriteLine("\nDigite o primeiro valor: ");
                    double res1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nDigite o segundo valor: ");
                    double res2 = Convert.ToDouble(Console.ReadLine());

                    if (res2 == 0.0)
                    {
                        Console.WriteLine("Erro ao gerar divisão por zero, tente novamente");
                        op = 4;
                    }
                    else
                    {
                        // Nem mesmo por (float) antes da operação deu certo
                        Console.WriteLine($"\n{res1} % {res2} = {res1 % res2}\n");
                    }
                    break;
                case 6:
                    Console.WriteLine("\nDigite a base: ");
                    double bas = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nDigite o expoente: ");
                    double exp = Convert.ToDouble(Console.ReadLine());

                    // Nem mesmo por (float) antes da operação deu certo
                    Console.WriteLine($"\n{bas}^({exp}) = {Math.Pow(bas, exp)}\n");

                    break;
                case 0:
                    Console.WriteLine("\nPrograma finalizado...");
                    op = 0;
                    break;
            }
        } while (op != 0);

    }
}