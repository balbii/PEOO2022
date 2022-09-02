using System;
class Program {
  public static void Main(){
    Circulo a = new Circulo();
    a.raio = 10;
    Console.WriteLine(a.Area());
  }
}
class Circulo{
  public int raio;
  public double Area(){
    double pi = 3.14;
    return pi * 2 * raio;
  }
}