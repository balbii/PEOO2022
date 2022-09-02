using System;
class Cinema {
  public static void Main(){
    Entrada spiderman = new Entrada();
    spiderman.Set_dia("ter");
    spiderman.SetHora(16);
    Console.WriteLine("Meia: R$" + spiderman.Meia());
    Console.WriteLine("Inteira: R$" + spiderman.Inteira());
  }
}
class Entrada {
  private string dia;
  private int hora;
  public void Set_dia(string s) {
    switch(s){
      case "seg": case "ter": case "qua": case "qui": case "sex":
      case "sab": case "dom": dia = s; break;
      default: Console.WriteLine("Erro: formato de dia inválido. Tente algo como: 'seg', 'ter', 'qua'..."); break;
    }
  }
  public void SetHora(int d){
    if (d >= 0 && d < 24) hora = d;
  }
  public string Get_dia(){
    return dia;
  }
  public int GetHora(){
    return hora;
  }
  public double Inteira(){
    double preco = 0;
    switch(dia){
      case "seg":
      case "ter":
      case "qui": preco = 16; break;
      case "qua": preco = 8; break;
      case "sex":
      case "sab":
      case "dom": preco = 20; break;
    }
    if (preco == 8) return preco;
    else{
      if (hora < 17) return preco;
      else return preco*1.5;
    }
  }
  public double Meia() {
    double preco = Inteira();
    if (preco == 8) return preco;
    else return preco/2;
  }
}