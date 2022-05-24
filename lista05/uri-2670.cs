using System;

class Coffee {
  public static void Main() {
    int a, b, c, tempo1, tempo2, tempo3;
    
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    
    tempo1 = b*2 + c*4;
    tempo2 = a*2 + c*2;
    tempo3 = a*4 + b*2;

    if (tempo2 <= tempo1 && tempo2 <= tempo3) Console.WriteLine(tempo2);
    else if (tempo3 <= tempo2 && tempo3<= tempo1) Console.WriteLine(tempo3);
    else Console.WriteLine(tempo1);
    
  }
}