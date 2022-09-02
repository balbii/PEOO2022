using System;
class Program {
  public static void Main() {
    Compra carro = new Compra();
    carro.SetTotal(80000);
    carro.SetParcelas(32);
    Console.WriteLine(carro.GetDesconto());
    Console.WriteLine(carro.GetParcelas());
  }
}
class Compra {
  private double total;
  private int n_parcela;
  public void SetTotal(double v) {
    if (v > 0) total = v;
  }
  public void SetParcelas(int n) {
    if (n > 0) n_parcela = n;
  }
  public double GetDesconto(){
    return total *0.85;
  }
  public double GetParcelas(){
    return total/n_parcela;
  }
}