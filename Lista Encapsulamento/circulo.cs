using System;
class Program {
  public static void Main() {
    Circulo lago = new Circulo();
    lago.SetRaio(10);
    Console.WriteLine(lago.GetRaio());
    Console.WriteLine(lago.Area());
    Console.WriteLine(lago.Comprimento());
  }
}
class Circulo {
  private double raio;
  public void SetRaio(double v) {
    if (v > 0) raio = v;
  }
  public double GetRaio() {
    return raio;
  }
  public double Area() {
    return Math.PI*raio*raio;
  }
  public double Comprimento() {
    return Math.PI*raio*2;
  }
}