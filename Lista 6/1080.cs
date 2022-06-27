using System;

class Program {
  public static void Main() {
    int k = 0;
    int maior = 0;
    int pos = 0;
    while (k < 100) {
      int input = int.Parse(Console.ReadLine());
      if (k == 0 || input > maior) {
        maior = input; pos = k+1; 
      }
      k += 1;
    }
    Console.WriteLine($"{maior}\n{pos}");
  }
}