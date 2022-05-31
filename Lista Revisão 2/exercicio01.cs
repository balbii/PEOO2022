using System;
class Maior {
  public static void Main() {
    Console.WriteLine("Digite dois números inteiros:");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    if (n1 > n2) Console.WriteLine("Maior = " + n1);
    else if (n1 == n2) Console.WriteLine("Números iguais");
    else Console.WriteLine($"Maior = {n2}");
  }
}