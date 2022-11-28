using CalculadoraIMC.Models.IMC;
using System.Globalization;
using System.Reflection.PortableExecutable;

public class program
{
    static void Main(string[] args)
    {
        double total, height, weight;

        Console.WriteLine("======= Calculadora IMC =======");
        Console.WriteLine();


        Console.WriteLine("Digite o seu nome:");
        String name = Console.ReadLine();

        Console.WriteLine("Digite a sua idade:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu peso");
        weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        height = double.Parse(Console.ReadLine());

        total = weight / (height * height);
        Console.WriteLine("Total: " + total.ToString("F2"));

        if ( total < 18.5 )
        {
            Console.WriteLine("MAGREZA!");
        }
        if ( total >= 18.5 && total < 24.9 )
        {
            Console.WriteLine("NORMAL!");
        }
        if ( total >= 25.0 && total < 29.9 )
        {
            Console.WriteLine("SOBREPESO GRAU 1");
        }
        if ( total >= 30.0 && total < 39.9 )
        {
            Console.WriteLine("OBESIDADE GRAU 2");
        }
        if ( total >= 40.0 )
        {
            Console.WriteLine("OBESIDADE GRAVE! GRAU 3!");
        }

        Console.ReadLine();

    }









}