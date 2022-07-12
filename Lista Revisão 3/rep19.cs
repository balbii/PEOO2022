using System;
class Program {
  public static void Main() {
    int k = 1;
    while (k < 11) {
      Console.WriteLine($"Tabuada do {k}");
      int v = 1;
      while (v < 11) {
        Console.WriteLine($"{k} x {v} = {k*v}");
        v++;
      }
      Console.WriteLine();
      k ++;
    }
  }
}