using System;
class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int k = 0; k < n; k++) {
      string[] input = Console.ReadLine().Split();
      int x = int.Parse(input[0]);
      int y = int.Parse(input[1]);
      Console.WriteLine(Mdc(x, y));
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
}