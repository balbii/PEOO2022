using System;

class Program{
  public static void Main() {
    Console.WriteLine("Digite tres valores inteiros:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(Maior(a,b,c));
  }
  public static double Maior(double a, double b, double c) {
    double maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    return maior;
  }
}
