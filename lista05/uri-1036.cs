using System;
class Bhaskara {
  public static void Main() {
    string[] entrada = Console.ReadLine().Split();
    double a = double.Parse(entrada[0]);
    double b = double.Parse(entrada[1]);
    double c = double.Parse(entrada[2]);
    double delta = b*b - 4*a*c;
    double x1 = (-b + Math.Sqrt(delta))/(2*a);
    double x2 = (-b - Math.Sqrt(delta))/(2*a);
    if (delta < 0 || a == 0) Console.WriteLine("Impossivel calcular");
    else {
      Console.WriteLine($"R1 = {x1:f5}"); 
      Console.WriteLine($"R2 = {x2:f5}");
    }
  }
}