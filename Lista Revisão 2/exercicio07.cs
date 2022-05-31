using System;
class Bhaskara {
  public static void Main() {
    Console.WriteLine("Digite os coeficientes a, b e c de uma equação do II grau:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double delta = b*b - 4*a*c;
    double x1 = (-b + Math.Sqrt(delta))/(2*a);
    double x2 = (-b - Math.Sqrt(delta))/(2*a);
    if (delta < 0 || a == 0) Console.WriteLine("Impossivel calcular");
    else Console.WriteLine($"As raízes são {x1} e {x2}");
  }
}