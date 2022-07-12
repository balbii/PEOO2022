using System;
class Program {
  public static void Main() {
    int k = 1;
    while (k < 31) {
      if (k % 3 == 0) Console.Write($"-{k} ");
      else Console.Write($"{k} ");
      k++;
    }
    Console.WriteLine();
  }
}