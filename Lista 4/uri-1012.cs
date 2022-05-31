using System;

class Area1012{
  public static void Main(){
    string[] entrada = Console.ReadLine().Split();
    double a = double.Parse(entrada[0]);
    double b = double.Parse(entrada[1]);
    double c = double.Parse(entrada[2]);
    double pi = 3.14159;
    Console.WriteLine($"TRIANGULO: {(a*c)/2:0.000}");
    Console.WriteLine($"CIRCULO: {c*c*pi:0.000}");
    Console.WriteLine($"TRAPEZIO: {(a+b)*c/2:0.000}");
    Console.WriteLine($"QUADRADO: {b*b:0.000}");
    Console.WriteLine($"RETANGULO: {a*b:0.000}");
  }
}