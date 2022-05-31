using System;
class Soma {
  public static void Main() {
    Console.WriteLine("Digite três valores inteiros:");
    int a, b, c, maior, menor;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    int[] numbers = {a, b, c};
    maior = a;
    menor = a;
    foreach (int i in numbers) {
      if (i > maior) maior = i;
      if (i < menor) menor = i;
    }
    Console.WriteLine($"A soma do maior com o menor número é {maior+menor}");
  }
}