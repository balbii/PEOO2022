using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string[] s = Console.ReadLine().Split();
    string senha = "";
    foreach (string p in s) {
      int n = p.Length;
      string t = n.ToString();
      senha += t;
    }
    Console.WriteLine(senha);
  }
}