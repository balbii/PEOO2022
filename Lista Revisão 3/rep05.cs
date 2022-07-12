using System;
class Program {
  public static void Main() {
    int k = 1;
    int c = 1;
    Console.Write(c);
    while (k < 46) {
      Console.Write($" {c+k}");
      k += c; c++;
    }
    Console.WriteLine();
  }
}