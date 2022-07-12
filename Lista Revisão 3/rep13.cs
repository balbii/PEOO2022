using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    string r = $"{s[0]}";
    s = s.Substring(1);
    foreach (char c in s) {
      r = c+r;
    }
    Console.WriteLine(r);
  }
}