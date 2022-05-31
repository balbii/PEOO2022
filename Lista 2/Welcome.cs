using System;

public class Welcome {
  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome:");
    string nome = Console.ReadLine();
    Console.WriteLine($"Bem vindo ao C#, {nome}");
  }
}