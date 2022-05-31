using System;
class Data {
  public static void Main() {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string[] entrada = Console.ReadLine().Split("/");
    int dd = int.Parse(entrada[0]);
    int mm = int.Parse(entrada[1]);
    int aa = int.Parse(entrada[2]);
    //erros gerais
    if (aa < 1900 || aa > 2100 || mm < 1 || mm > 12 || dd < 1) Console.WriteLine("A data informada não é válida");
    //meses de 31 dias
    else if ((mm == 1 || mm == 3 || mm == 5 || mm == 7 || mm == 8 || mm == 10 || mm == 12) && dd > 31) Console.WriteLine("A data informada não é válida");
    //meses de 30 dias
    else if ((mm == 4 || mm == 6 || mm == 9 || mm == 11) && dd > 30) Console.WriteLine("A data informada não é válida");
    //fevereiro
    else if ((mm == 2 && aa % 4 == 0 && dd > 29) || (mm == 2 && aa % 4 != 0 && dd > 28)) Console.WriteLine("A data informada não é válida");
    else Console.WriteLine("A data informada é válida");
  }
}