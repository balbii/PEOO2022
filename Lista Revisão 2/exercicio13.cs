using System;
class Sequencia {
  static void Main() {
    Console.WriteLine("Digite dez valores inteiros");
    string[] entrada = Console.ReadLine().Split();
    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]);
    int c = int.Parse(entrada[2]);
    int d = int.Parse(entrada[3]);
    int e = int.Parse(entrada[4]);
    int f = int.Parse(entrada[5]);
    int g = int.Parse(entrada[6]);
    int h = int.Parse(entrada[7]);
    int i = int.Parse(entrada[8]);
    int j = int.Parse(entrada[9]);

    int[] lista = {a,b,c,d,e,f,g,h,i,j};
    int menor = a;
    int maior = a;
    foreach (int k in lista) {
      if (k > maior) maior = k;
      if (k < menor) menor = k;
    }
    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  }
}