using System;
class Ponteiros {
  public static void Main() {
    Console.WriteLine("Digite o horário no formato hh:mm");
    string[] entrada = Console.ReadLine().Split(":");
    int horas = int.Parse(entrada[0]);
    int minutos = int.Parse(entrada[1]);
    if (horas > 12 || horas < 0 || minutos < 0 || minutos > 60) Console.WriteLine("Erro: Horário Inválido");
    else {
      int graus_min = minutos*6;
      double coeficiente = (5.0/60.0)*graus_min;
      double graus_h = horas*30 + coeficiente;
      double graus = graus_min - graus_h;
      if (graus < 0) graus = graus*-1;
      
      if (graus <= 180) Console.WriteLine("Menor ângulo entre os ponteiros = " + graus);
      else {
        graus = 360 - graus;
        Console.WriteLine("Menor ângulo entre os ponteiros = " + graus);
      }
    }
  }
}