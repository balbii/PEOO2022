using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string[] s = Console.ReadLine().Split();
    int v = s.Length;
    Console.WriteLine(v);
  }
}