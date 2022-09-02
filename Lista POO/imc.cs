using System;
class Program {
  public static void Main(){
    IMC renan = new IMC();
    renan.SetPeso(66);
    renan.SetAltura(1.82);
    Console.WriteLine(renan.CalcIMC());
  }
}
class IMC {
  private double peso, altura;
  public void SetPeso(double p){
    if (p > 0) peso = p;
  }
  public void SetAltura(double a) {
    if (a > 0) altura = a;
  }
  public double GetAltura(){
    return altura;
  }
  public double GetPeso(){
    return peso;
  }
  public double CalcIMC(){
    return peso/ (altura*altura);
  }
}