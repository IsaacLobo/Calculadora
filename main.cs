using System;

class MainClass {
  public static void Main (string[] args) {
    
    double num1, num2, resultado;
    bool opcoesBool = true;
    int escolha = 0;
    
    
    while(opcoesBool)
  {
    Console.WriteLine ("Escolha uma das opções abaixo");
    Console.WriteLine ("1. Soma");
    Console.WriteLine ("2. Subtração");
    Console.WriteLine ("3. Multiplicação");
    Console.WriteLine ("4. Divisão");
    Console.WriteLine ("5. Sair");
    escolha = Int32.Parse(Console.ReadLine());
  
    switch(escolha)
    {
          case 1:
            
            Console.WriteLine ("Soma, Escolha dois números para somar");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("O resultado da soma de dois número é " + resultado);
          break;
          case 2:              
              Console.WriteLine ("Subtração, Escolha dois números para subtrair");
              num1 = Double.Parse(Console.ReadLine());
              num2 = Double.Parse(Console.ReadLine());
              resultado = num1 - num2;
              Console.WriteLine("O resultado da soma de dois número é " + resultado);
              break;
          case 3:              
              Console.WriteLine ("Multiplicação, Escolha dois números para multiplicar");
              num1 = Double.Parse(Console.ReadLine());
              num2 = Double.Parse(Console.ReadLine());
              resultado = num1 * num2;
              Console.WriteLine("O resultado da multiplicação de dois número é " + resultado);
          break;
          case 4:              
              Console.WriteLine ("Divisão, Escolha dois números para dividir");
             num1 = Double.Parse (Console.ReadLine());
             num2 = Double.Parse (Console.ReadLine());
             resultado = num1 / num2;
              Console.WriteLine("O resultado da divisão de dois número é " + resultado);
          break;
          case 5:              
            opcoesBool = false;
          break;
          default:
              Console.WriteLine("Opção Não encontrada");
              break;
      
    }
  }
  }
}