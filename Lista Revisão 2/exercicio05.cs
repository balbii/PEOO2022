using System;
class Meses {
  public static void Main() {
    Console.WriteLine("Informe o número do mês");
    int mes = int.Parse(Console.ReadLine());
    
    string[] meses = {"0", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
    string[] ordens = {"0", "primeiro", "segundo", "terceiro", "quarto"};
    
    int ordem = 0;
    if (mes > 0 || mes <=3) ordem = 1;
    else if (mes > 3 || mes <=6) ordem = 2;
    else if (mes > 6 || mes <=9) ordem = 3;
    else if (mes > 9 || mes <=12) ordem = 4;
    
    Console.WriteLine($"O mês de {meses[mes]} é do {ordens[ordem]} trimestre do ano");
  }
}