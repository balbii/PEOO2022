using System;

class Combustivel1017{
  public static void Main() {
    int horas = int.Parse(Console.ReadLine());
    int vel_med = int.Parse(Console.ReadLine());
    double kms = horas*vel_med*1.0;
    Console.WriteLine($"{kms/12:0.000}");
  }
}