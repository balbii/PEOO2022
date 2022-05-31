using System;
class Verificacao {
  public static void Main() {
    Console.WriteLine("Digite quatro valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int[] lista = {a, b, c, d};
    if (a == b || a == c || a == d || b == c || b == d || c == d) Console.WriteLine("Erro: Valores repetidos");
    else {
      int maior = a;
      int menor = a;
      foreach (int i in lista){
        if (i > maior) maior = i;
        if (i < menor) menor = i;
      }
      int soma_e = (a+b+c+d) - (maior+menor);
      Console.WriteLine($"Maior valor = " + maior);
      Console.WriteLine($"Menor valor = " + menor);
      Console.WriteLine($"A Soma do segundo maior valor com o segundo menor valor = {soma_e}");
    }
  }
}