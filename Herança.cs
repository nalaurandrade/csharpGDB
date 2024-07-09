/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Veiculo { // Classe base
    public int rodas;
    public int velMax;
    private bool ligado; // private só pode ser acessado na própria class
    
    public void ligar() {
        ligado = true;
    }
    
    public void desligar() {
        ligado = false;
    } 
    
    public string getLigado() {
        if (ligado) {
            return "sim";
        } else {
            return "não";
        }
    }
} 

class Carro : Veiculo {
    public string nome;
    public string cor;
    
    public Carro(string nome, string cor) {
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34 {
    static void Main() {
        Carro c1 = new Carro("Rapidão", "vermelho");
        c1.ligar(); // Corrigido para usar o método ligar em vez de acessar diretamente a variável privada
        
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Rodas: {0}", c1.rodas); // Corrigido para acessar o atributo correto
        Console.WriteLine("Vel. Máxima: {0}", c1.velMax); // Corrigido para acessar o atributo correto
        Console.WriteLine("Ligado: {0}", c1.getLigado());
    }
}
