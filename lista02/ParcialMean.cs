using System;

public class ParcialMean {
  public static void Main(string[] args) {
    Console.WriteLine("Digite sua nota do primeiro bimestre:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite ssua nota do segundo bimestre:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"Média Parcial = {(a*2+b*3)/5}");
  }
}