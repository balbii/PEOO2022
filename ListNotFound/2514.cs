using System;
class Pifjerwpi {
  public static void Main() {
    bool rodar = true;
    while(rodar) {
      string s = Console.ReadLine();
      if (string.IsNullOrEmpty(s)) {rodar = false;}
      else {
        int m = int.Parse(s);
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int prod = a*b*c;
        int x = Mdc(a, b);
        int mmc = prod/Mdc(x, c);
        Console.WriteLine($"{mmc - s}");
      }
    }
  }
  
  public static int Mdc(int x, int y) {
  int menor = x;
  int maior = y;
  if (y < x) {menor = y; maior = x;}
  int resto = maior % menor;
  if (resto == 0) return menor; else{
    while (resto != 0) {
      maior = menor; menor = resto; resto = maior % menor;
    } return menor;
  }
}