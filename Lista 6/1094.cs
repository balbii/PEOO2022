using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int total = 0;
    int ratos = 0;
    int sapos = 0;
    int coelhos = 0;
    for (int k = 0; k < n; k++) {
      string[] input = Console.ReadLine().Split();
      int a = int.Parse(input[0]);
      string b = input[1];
      total += a;
      if (b == "R") ratos += a;
      else if (b == "S") sapos += a;
      else if (b == "C") coelhos += a;
    }
    Console.WriteLine($"Total: {total} cobaias");
    Console.WriteLine($"Total de coelhos: {coelhos}");
    Console.WriteLine($"Total de ratos: {ratos}");
    Console.WriteLine($"Total de sapos: {sapos}");
    
    double p_coelhos = ((coelhos*1.00)/total)*100;
    double p_ratos = ((ratos*1.00)/total)*100;
    double p_sapos = ((sapos*1.00)/total)*100;
    
    Console.WriteLine($"Percentual de coelhos: {p_coelhos:00.00} %");
    Console.WriteLine($"Percentual de ratos: {p_ratos:00.00} %");
    Console.WriteLine($"Percentual de sapos: {p_sapos:00.00} %");
  }
}