/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

public class Carteira 
    {
      private int dinheiro; // private tó pode ser alterado pela própria classe
      
      public int Dinheiro {get;set;}
    }
  public class Joao
  {
    static void Main(string[] args)
    {
        Carteira cart = new Carteira();
        cart.Dinheiro = 50;
     
        Console.WriteLine("O saldo é: " + cart.Dinheiro);

    }
  }
