/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção: 1 para multiplicação, 2 para soma, 3 para subtração e 4 para sair");
        Console.Write("\r\nSelecione uma opção: ");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Digite o valor de x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de y:");
                int y = int.Parse(Console.ReadLine());
                int multiplicacao = x * y;
                Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            case "2":
                Console.WriteLine("Digite o valor de a:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de b:");
                int b = int.Parse(Console.ReadLine());
                int soma = a + b;
                Console.WriteLine($"O resultado da soma é: {soma}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            case "3":
                Console.WriteLine("Digite o valor de a:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de b:");
                int d = int.Parse(Console.ReadLine());
                int subtracao = c - d;
                Console.WriteLine($"O resultado da subtração é: {subtracao}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            case "4":
                return false;
            default:
                Console.WriteLine("Opção inválida. Escolha novamente.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
        }
    }
}
