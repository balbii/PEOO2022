using System;
class Program {
  public static void Main() {
    Viagem recife = new Viagem();
    recife.km = 280;
    recife.horas = 3;
    recife.minutos = 30;
    Console.WriteLine(recife.VelocidadeMedia());
  }
}
class Viagem {
  public double km;
  public double horas;
  public double minutos;
  public double VelocidadeMedia(){
    double tempo = horas + minutos/60;
    return km / tempo;
  }
}