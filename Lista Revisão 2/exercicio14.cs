using System;
class Triangulo {
  static void Main() {
    Console.WriteLine("digite tres valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    if (a < (b+c) && b < (a+c) && c < (a+b)) {
      Console.WriteLine("Triangulo válido");
      if (a != b && a != c && b != c) Console.WriteLine("escaleno");
      else if (a == b && a == c && b == c) Console.WriteLine("equilatero");
      else if (a == b || a == c || b == c) Console.WriteLine("isosceles");
    } else Console.WriteLine("Triângulo inválido");
  }
}