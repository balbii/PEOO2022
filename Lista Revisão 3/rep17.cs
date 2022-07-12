using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    foreach (string p in v) {
      int vogais = 0;
      foreach (char c in p) {
        if (c == 'a' || c == 'e'|| c == 'i'|| c == 'o'|| c == 'u') vogais += 1;
      }
      int k = 0;
      while (k < vogais) {
        Console.Write(p + " ");
        k++;
      }
    }
    Console.WriteLine();
  }
}