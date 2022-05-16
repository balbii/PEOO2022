using System;

public class Rectangle {
  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retangulo:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"Área = {a*b:.00} - Perímetro = {2*a + 2*b:.00} - Diagonal = {Math.Sqrt(a*a + b*b):.00}");
  }
}