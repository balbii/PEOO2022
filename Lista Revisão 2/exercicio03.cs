using System;
class Somas {
  public static void Main() {
    Console.WriteLine("Digite quatro números inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int[] numeros = {a, b, c, d};
    int soma_pares = 0;
    int soma_impares = 0;
    
    foreach (int i in numeros) {
      if (i % 2 == 0) soma_pares += i;
      else soma_impares += i;
    }
    Console.WriteLine("Soma dos pares = " + soma_pares);
    Console.WriteLine("Soma dos impares = " + soma_impares);
  }
}