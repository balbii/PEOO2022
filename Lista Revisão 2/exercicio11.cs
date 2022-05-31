using System;
class Data {
  public static void Main() {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string[] entrada = Console.ReadLine().Split("/");
    int dd = int.Parse(entrada[0]);
    int mm = int.Parse(entrada[1]);
    int aa = int.Parse(entrada[2]);
    string[] meses = {"0", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
    Console.WriteLine($"A data é {dd} de {meses[mm]} de {aa}");
  }
}