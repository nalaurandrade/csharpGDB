/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {

    int n1, n2, n3, n4,res;
    res=n1=n2=n3=n4=0;
    string resultado;

    Console.Write("Digite a nota1: ");
    n1=int.Parse(Console.ReadLine());
    
    Console.Write("Digite a nota2: ");
    n2=int.Parse(Console.ReadLine());
    
    Console.Write("Digite a nota3: ");
    n3=int.Parse(Console.ReadLine());

    Console.Write("Digite a nota4: ");
    n4=int.Parse(Console.ReadLine());
    
    res=n1+n2+n3+n4;
    
    //>=60 - Aprovado
    //59 e 40 - Recuperação
    //<40 - Reprovado
    
    //65
    
    if(res >= 60){
        resultado="Aprovado";
    }else
        if(res >= 40){
            resultado="Recuperação";        
    }
    else
        {
        resultado="Reprovado";
        }

    Console.WriteLine("Nota: {0} - Resultado:{1}",res,resultado);
  }
}