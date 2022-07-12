using System;
class Program {
  public static void Main() {
    int k = 1;
    while (k < 31) {
      Console.Write($"{k} ");
      if (k % 3 == 0) Console.Write($"{k + Antecessor(k) + Antecessor(k-1)} ");
      k++;
    }
    Console.WriteLine();
  }
  public static int Antecessor(int a) {
    return (a-1);
  }
}