using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string[] s = Console.ReadLine().Split(",");
    int soma = 0;
    foreach (string g in s) {
      int a = int.Parse(g);
      soma += a;
    }
    Console.WriteLine($"Soma = {soma}");
  }
}