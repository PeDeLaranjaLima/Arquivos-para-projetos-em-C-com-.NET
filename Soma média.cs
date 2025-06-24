using System;

class Program
{
    public static void Main(string[] args)
    {

        // Console.Read() -> lê um caractere apenas
        // Console.ReadLine() -> lê a linha até receber um enter

        // Fonte: https://www.devmedia.com.br/csharp-trabalhando-com-arrays/38596
        // int[] array = new int[10];

        int op = 0;
        double[] num = new double[10];
        int i = 0;
        for (i = 0; i <= 9; i++)
        {
            Console.WriteLine($"\nDigite o {i + 1}° valor: ");
            num[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deseja digitar mais um valor? 1 - Sim ou 2 - Não");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 2 && i < 2)
            {
                Console.WriteLine("Você deve digitar mais valores (mínimo 3)");
            }
            else if (op == 2 && i >= 2)
            {
                break;
            }
        }
        for (int j = 0; j <= i; j++)
        {
            Console.WriteLine($"\nOs valores digitados foram: {num[j]}");
            double soma = num[j] + num[j + 1];
            Console.WriteLine($"\nA média dos valores é: {soma / i + 1}");
        }
    }
}