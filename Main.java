package Calculator;

import java.util.Scanner;

public class Main {
  private static Scanner scanner = new Scanner(System.in);
  private static String column = "=============================================";

  public static void main(String[] args) {
    menu();
  }
  private static void menu() {
    System.out.println(column);
    System.out.println("Welcome! What do you want to do?");
    System.out.println(column);

    System.out.println("1: Addition");
    System.out.println("2: Subtraction");
    System.out.println("3: Multiplication");
    System.out.println("4: Division");
    System.out.println("5: Rest of Division");
    System.out.println("6: Potentiation");
    System.out.println("7: Square Root");
    System.out.println("0: Go to out");
    System.out.println(column);

    System.out.println("Select a option: ");
    byte option = scanner.nextByte();

    if(option == 0) {
      // ANSI escape code to clear the console screen
      System.out.print("\033[H\033[2J");
      System.out.flush();  // Ensures the output is immediately printed

      System.out.println(column);
      System.out.println("============= Goodbye!! ===============");
      System.out.println(column);
      System.exit(0);
    }

    handleOption(option);
  }

  private static void handleOption(short option) {
    switch(option) {
      case 1: addition(); break;
      case 2: subtraction(); break;
      case 3: multiplication(); break;
      case 4: division(); break;
      case 5: restOfDivision(); break;
      case 6: potentiation(); break;
      case 7: squareRoot(); break;

      default: {
        System.out.println(column);
        System.out.println("Option not valid!");

        // ANSI escape code to clear the console screen
        System.out.print("\033[H\033[2J");
        System.out.flush();  // Ensures the output is immediately printed
        break;
      }
    }
  }

  private static void addition() {
    System.out.println("Type a first value: ");
    double x = scanner.nextDouble();

    System.out.println("Type a second value: ");
    double y = scanner.nextDouble();

    double result = x + y;

    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }

  private static void subtraction() {
    System.out.println("Type a first value: ");
    double x = scanner.nextDouble();

    System.out.println("Type a second value: ");
    double y = scanner.nextDouble();

    double result = x - y;

    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }

  private static void multiplication() {
    System.out.println("Type a first value: ");
    double x = scanner.nextDouble();

    System.out.println("Type a second value: ");
    double y = scanner.nextDouble();

    double result = x * y;

    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }

  private static void division() {
    System.out.println("Type a first value: ");
    double x = scanner.nextDouble();

    System.out.println("Type a second value: ");
    double y = scanner.nextDouble();

    double result = x / y;
    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }

  private static void restOfDivision() {
    System.out.println("Type a first value: ");
    double x = scanner.nextDouble();

    System.out.println("Type a second value: ");
    double y = scanner.nextDouble();

    double result = x % y;
    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }

  private static void potentiation() {
    System.out.print("\nType a first value: ");
    double x = scanner.nextDouble();

    System.out.print("\nType a second value: ");
    double y = scanner.nextDouble();

    double result = Math.pow(x, y);
    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }

  private static void squareRoot() {
    System.out.println("Type a value: ");
    double x = scanner.nextDouble();

    double result = Math.sqrt(x);
    System.out.println(result);

    // ANSI escape code to clear the console screen
    System.out.print("\033[H\033[2J");
    System.out.flush();  // Ensures the output is immediately printed
    menu();
  }
}