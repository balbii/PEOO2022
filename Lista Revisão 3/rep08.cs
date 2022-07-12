using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string[] s = Console.ReadLine().Split();
    int n = s.Length;
    int k = 0;
    while (k< n) {
      string sk = s[k];
      int last = sk.Length - 1;
      Console.Write(sk[last]);
      k++;
    }
    Console.WriteLine();
  }
}