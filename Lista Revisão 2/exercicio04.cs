using System;
class Horas {
  public static void Main() {
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string[] entrada1 = Console.ReadLine().Split(":");
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string[] entrada2 = Console.ReadLine().Split(":");
    int minutos = int.Parse(entrada1[1]) + int.Parse(entrada2[1]);
    int horas = int.Parse(entrada1[0]) + int.Parse(entrada2[0]);
    if (minutos >= 60) {
      horas += 1; minutos -= 60;
    }
    Console.WriteLine($"Total de horas = {horas:00.}:{minutos:00.}");
  }
}