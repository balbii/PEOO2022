using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int n = 0;
    foreach (char c in s) {
      n++;
    }
    int k = 0;
    while (k < n) {
      Console.WriteLine($"{k+1} - {s}");
      k++;
    }
  }
}