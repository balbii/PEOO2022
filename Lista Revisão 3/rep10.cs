using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int n = 0;
    foreach (char c in s) {
      n++;
    }
    int k = 0;int i, f;
    while (k < n) {
      f = k+1;
      i = n - (f);
      Console.WriteLine(s.Substring(f, i) + s.Substring(0, f));
      k++;
    }
    
  }
}