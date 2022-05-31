using System;
class Crescente {
  static void Main() {
    Console.WriteLine("Digite tres valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int[] lista = {a,b,c};
    int menor = a;
    int maior = a;
    foreach (int k in lista) {
      if (k > maior) maior = k;
      if (k < menor) menor = k;
    }
    int meio = (a+b+c) - (maior+menor);
    Console.WriteLine($"{menor}, {meio}, {maior}");
  }
}