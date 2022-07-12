using System;
class Program {
  public static void Main() {
    int k = 1;
    while (k < 11) {
      if (k % 2 == 0) Console.Write($"-{k} ");
      else Console.Write($"{k} ");
      k++;
    }
    Console.WriteLine();
  }
}