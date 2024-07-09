/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Veiculo { // Classe base
    public int velAtual;
    private int velMax; // restringe o acesso ao membro à classe
    protected bool ligado; // permite o acesso aos membros pelas classes derivadas
    
    public Veiculo(int velMax) { // necessita de argumento
        velAtual = 0;
        this.velMax = velMax; // Corrigido para atribuir ao membro da classe
        ligado = false;
    }
    
    public bool getLigado() {
        return ligado;
    }
    
    public int getVelMax() {
        return velMax;
    }
}

class Carro : Veiculo { // Derivada de veiculo
    public string nome;
    
    public Carro(string nome, int vm) : base(vm) { // Ajustei a sintaxe do construtor
        this.nome = nome;
        ligado = true;
    }
}

class HelloWorld {
    static void Main() {
        Carro carro = new Carro("Bonitão", 120);
        Console.WriteLine("Nome: {0}", carro.nome);    
        Console.WriteLine("Vel. Máxima: {0}", carro.getVelMax());
        Console.WriteLine("Ligado: {0}", carro.getLigado());    
    }
}
