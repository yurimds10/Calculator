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
      Console.WriteLine("5 - Resto da Divisão");
      Console.WriteLine("6 - Potenciação");
      Console.WriteLine("7 - Raiz Quadrada");
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
      
      HandleOption(option);
    }

    static void HandleOption(short option)
    {
      Console.Clear();

      switch(option)
      {
        case 1: Addition(); break;
        case 2: Subtraction(); break;
        case 3: Multiplication(); break;
        case 4: Division(); break;
        case 5: RestDivision(); break;
        case 6: Potenciation(); break;
        case 7: Square(); break;
        default:
        {
          Console.WriteLine("Por favor, digite uma opção válida!");
          Console.ReadKey();
          Console.Clear();
          Menu();
        }; break;
      }
    }

    static void Addition()
    {
      Console.WriteLine(Program.column);
      Console.Write("Digite o primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Digite o segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      Console.WriteLine($"O resultado da soma é: {num1 + num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Subtraction()
    {
      Console.WriteLine(Program.column);
      Console.Write("Digite o primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Digite o segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Multiplication()
    {
      Console.WriteLine(Program.column);
      Console.Write("Digite o primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Digite o segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);
      
      Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Division()
    {
      Console.WriteLine(Program.column);
      Console.Write("Digite o primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Digite o segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void RestDivision()
    {
      Console.WriteLine(Program.column);
      Console.Write("Digite o primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Digite o segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      Console.WriteLine($"O resultado do resto da divisão é: {num1 % num2}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Potenciation()
    {
      Console.WriteLine(Program.column);
      Console.Write("Digite o primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine(Program.column);
      Console.Write("Digite o segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine(Program.column);

      Console.WriteLine($"O resultado da potenciação é: {Math.Pow(num1, num2)}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }

    static void Square()
    {Console.WriteLine(Program.column);
      Console.Write("Digite um valor: ");
      double num = double.Parse(Console.ReadLine());

      Console.WriteLine($"O resultado da raiz quadrada é: {Math.Sqrt(num)}");
      Console.ReadKey();
      Console.Clear();
      Menu();
    }
  }
}