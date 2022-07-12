using System;
class program {
  public static void Main() {
    Console.WriteLine(Maior(10, 12));
  }
  public static double Maior(double x, double y) {
    double maior = x;
    if (y > x) maior = y;
    return maior;
  }
}