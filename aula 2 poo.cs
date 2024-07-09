/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class Jogador {
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
    energia = 100;
    vivo=true;
    nome=n;
    }
}
  class Aula29{
  static void Main() {
    
    string nome1;
    Console.WriteLine("Digite o nome do jodador 1: ");
    nome1=Console.ReadLine();
    Jogador j1=new Jogador(nome1);
    Jogador j2=new Jogador("Théo");

    Console.WriteLine("Energia do jogador 1: {0}",j1.nome);
    Console.WriteLine("Energia do jogador 2: {0}",j2.nome);
    }
}