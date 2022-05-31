using System;
class Operacao {
  static void Main() {
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string entrada = Console.ReadLine();
    string[] s = entrada.Split('+','-','*','/');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    char[] operadores = {'+','-','*','/'};
    char operador = '+';
    foreach (char c in operadores) {
      if (entrada.IndexOf(c) > -1) operador = c;
    }
    int total = 0;
    if (operador == '+') total = a+b;
    else if (operador == '-') total = a-b;
    else if (operador == '*') total = a*b;
    else if (operador == '/') total = a/b;
    Console.WriteLine(total);
  }
}