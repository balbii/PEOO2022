using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine().ToLower();
    int conta = 0; int conte = 0; int conti = 0;
    int conto = 0; int contu = 0;
    foreach (char c in s) {
      if (c == 'a') conta += 1;
      if (c == 'e') conte += 1;
      if (c == 'i') conti += 1;
      if (c == 'o') conto += 1;
      if (c == 'u') contu += 1;
    }
    Console.WriteLine($"A - {conta}");
    Console.WriteLine($"E - {conte}");
    Console.WriteLine($"I - {conti}");
    Console.WriteLine($"O - {conto}");
    Console.WriteLine($"U - {contu}");
  }
}