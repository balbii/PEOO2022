using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int k = 0; k < n; k++) {
      string[] input = Console.ReadLine().Split();
      int x = int.Parse(input[0]);
      int y = int.Parse(input[1]);
      if (y == 0) Console.WriteLine("divisao impossivel");
      else if (x == 0) Console.WriteLine("0.0");
      else{
        double res = (x*1.0)/y;
        Console.WriteLine($"{res:0.0}");
      }
    }
  }
}