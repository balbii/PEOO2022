using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int k = 0;
    do {
      Console.WriteLine(s);
      k = s.IndexOf(" ");
      s = s.Substring(k+1);
    } while(k != -1);
  }
}