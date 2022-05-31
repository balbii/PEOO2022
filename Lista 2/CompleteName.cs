using System;

public class CompleteName {
  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome completo:");
    string nome = Console.ReadLine();
    string[] c = nome.Split();
    Console.WriteLine($"Bem vindo ao C#, {c[0]}");
  }
}