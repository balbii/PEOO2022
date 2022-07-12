using System;
class Program {
  public static void Main() {
    int k = 1;
    while (k < 11) {
      Console.Write(k + " ");
      int v = 1;
      while (v < k+1) {
        if (v % 2 == 0) Console.Write(v+ " ");
        v++;
      }
      k++;
      Console.WriteLine();
    }
  }
}