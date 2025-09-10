using System.Data;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Qual operação que deseja fazer\n");

Console.WriteLine("1. Soma");
Console.WriteLine("2. Subatração");
Console.WriteLine("3. Multiplicação");
Console.WriteLine("4. Divisão \n");

int opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        Console.WriteLine("Digite o primeiro numero:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        int resultado = num1 + num2;
        Console.WriteLine($"Reusltado: {resultado}");
        break;

    case 2:
        Console.WriteLine("Digite o primeiro numero: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int num4 = int.Parse(Console.ReadLine());
        int resultado2 = num3 - num4;
        Console.WriteLine($"Resultado: {resultado2}");
        break;

    case 3:
        Console.WriteLine("Digite o primeiro numero: ");
        int num5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int num6 = int.Parse(Console.ReadLine());
        int resultado3 = num5 * num6;
        Console.WriteLine($"Resultado: {resultado3}");
        break;
        
         case 4:
        Console.WriteLine("Digite o primeiro numero: ");
        double num7 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        double num8 = int.Parse(Console.ReadLine());
        double resultado4 = num7 / num8;
        Console.WriteLine($"Resultado: {resultado4}");
        break;
}