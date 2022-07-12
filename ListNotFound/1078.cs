using System;
class idsj {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int c = 1; c < 11; c++) {
      Console.WriteLine($"{c} x {n} = {c*n}");
    }
  }
}