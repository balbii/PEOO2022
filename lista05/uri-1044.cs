using System;
class Multiplos {
  public static void Main() {
    string[] entrada = Console.ReadLine().Split();
    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]);
    if (b%a == 0) Console.WriteLine("Sao Multiplos");
    else Console.WriteLine("Nao sao Multiplos");
  }
}