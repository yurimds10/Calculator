namespace Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.WriteLine("==============================");
      Console.WriteLine("Bem vindo! O que deseja fazer?");
      Console.WriteLine("==============================");

      Console.WriteLine("1 - Adição");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("0 - Sair");

      Console.WriteLine("==============================");
      Console.Write("Selecione uma opção:");
      short option = short.Parse(Console.ReadLine());
      Console.WriteLine("==============================");
      
      switch(option)
      {
        case 1: Addition(); break;
        case 2: Subtraction(); break;
        case 3: Multiplication(); break;
        case 4: Division(); break;
        case 0: 
        {
          Console.Clear();
          Console.WriteLine("Até logo!");
          System.Environment.Exit(0);
        }; break;
        default: Menu(); break;
      }
    }

    static void Addition()
    {      
      Console.Clear();

      Console.WriteLine("=========================");
      Console.Write("Primeiro valor: ");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine("=========================");
      Console.Write("Segundo valor: ");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine("=========================");

      double result = num1 + num2;
      Console.WriteLine($"O resultado da soma é: {result}");
      Console.ReadKey();
      Menu();
    }

    static void Subtraction()
    {
      Console.Clear();

      Console.WriteLine("=========================");
      Console.WriteLine("Primeiro valor:");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine("=========================");
      Console.WriteLine("Segundo valor:");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine("=========================");

      double result = num1 - num2;
      Console.WriteLine($"O resultado da subtração é: {result}");
      Console.ReadKey();
      Menu();
    }

    static void Multiplication()
    {
      Console.Clear();

      Console.WriteLine("=========================");
      Console.WriteLine("Primeiro valor:");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine("=========================");
      Console.WriteLine("Segundo valor:");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine("=========================");

      double result = num1 * num2;
      Console.WriteLine($"O resultado da multiplicação é: {result}");
      Console.ReadKey();
      Menu();
    }

    static void Division()
    {
      Console.Clear();

      Console.WriteLine("=========================");
      Console.WriteLine("Primeiro valor:");
      double num1 = double.Parse(Console.ReadLine());

      Console.WriteLine("=========================");
      Console.WriteLine("Segundo valor:");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine("=========================");

      double result = num1 / num2;
      Console.WriteLine($"O resultado da divisão é: {result}");
      Console.ReadKey();
      Menu();
    }
  }
}