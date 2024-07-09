/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class Jogador {
    public int energia=100;
    public bool vivo=true;
}
  class Aula28{
  static void Main() {
    Jogador j1=new Jogador();
    Jogador j2=new Jogador(); 
    Jogador j3=new Jogador();
    
    j1.energia=50;
    Console.WriteLine("Energia do jogador 1: {0},j1.energia");
    }
}