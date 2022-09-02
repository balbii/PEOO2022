using System;
class Cinema {
  public static void Main(){
    Entrada aladdin = new Entrada();
    aladdin.dia = "qui";
    aladdin.hora = 17;
    Console.WriteLine(aladdin.Meia());
    Console.WriteLine(aladdin.Inteira());
  }
}
class Entrada {
  public string dia;
  public int hora;
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
      if (hora > 17) return preco;
      else return preco*1.5;
    }
  }
  public double Meia() {
    double preco = Inteira();
    if (preco == 8) return preco;
    else return preco/2;
  }
}