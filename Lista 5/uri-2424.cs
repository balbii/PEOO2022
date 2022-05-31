using System;

class Tenis {
  public static void Main() {
    string[] entrada = Console.ReadLine().Split();
    int x = int.Parse(entrada[0]);
    int y = int.Parse(entrada[1]);
    if (x < 0 || x > 432 || y < 0 || y > 468) Console.WriteLine("fora");
    else Console.WriteLine("dentro");
  }
}