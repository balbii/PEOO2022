using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string[] s = Console.ReadLine().Split();
    int n = s.Length;
    int k = 0;
    while (k<n) {
      string g = s[k];
      string r = $"{g[0]}";
      g = g.Substring(1);
      foreach (char c in g) {
        r = c+r;
      }
      Console.WriteLine(r);
      k++;
    }
  }
}