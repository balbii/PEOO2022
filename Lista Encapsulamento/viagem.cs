using System;
class Program {
  public static void Main() {
    Viagem recife = new Viagem();
    recife.Set_km(280);
    recife.Set_time(3.5);
    Console.WriteLine(recife.VelocidadeMedia());
  }
}
class Viagem {
  private double km, tempo;
  public void Set_km(double m) {
    if (m > 0) km = m;
  }
  public void Set_time(double t) {
    if (t > 0) tempo = t;
  }
  public double Get_km() {
    return km;
  }
  public double Get_time() {
    return tempo;
  }
  public double VelocidadeMedia(){
    return km / tempo;
  }
}