namespace Calculator
{
  class Program
  {
    private static string column = "==============================";
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.WriteLine(Program.column);
      Console.WriteLine("Bem vindo! O que deseja fazer?");
      Console.WriteLine(Program.column);

      Console.WriteLine("1 - Adição");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("0 - Sair");
      Console.WriteLine(Program.column);
      
      Console.Write("Selecione uma opção: ");
      short option = short.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      if(option == 0)
      {
        Console.Clear();
        Console.WriteLine(Program.column);
        Console.WriteLine("======== Até logo :) =========");
        Console.WriteLine(Program.column);
        System.Environment.Exit(0);
      }
      
      HandleData(option);
    }

    static void HandleData(short option)
    {
      Console.Clear();
      Console.WriteLine($"Option: {option}");
      double num1, num2;

      Console.WriteLine(Program.column);
      Console.Write("Primeiro valor: ");
      num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Segundo valor: ");
      num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      switch(option)
      {
        case 1: Addition(num1, num2); break;
        case 2: Subtraction(num1, num2); break;
        case 3: Multiplication(num1, num2); break;
        case 4: Division(num1, num2); break;
        default: Menu(); break;
      }
    }

    static void Addition(double num1, double num2)
    {      
      Console.WriteLine($"O resultado da soma é: {num1 + num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Subtraction(double num1, double num2)
    {
      Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Multiplication(double num1, double num2)
    {
      Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Division(double num1, double num2)
    {
      Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }
  }
}