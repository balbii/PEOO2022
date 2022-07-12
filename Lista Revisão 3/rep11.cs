using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int soma = 0;
    foreach (char c in s) {
      if (Numero(c)) {
        string b = c.ToString();
        int a = int.Parse(b);
        soma += a;
      }
    }
    Console.WriteLine(soma);
  }
  public static bool Numero(char v) {
    return Char.IsNumber(v);
  }
}