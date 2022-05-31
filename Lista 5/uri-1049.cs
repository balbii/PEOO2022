using System;

class Animal {
  public static void Main() {
    string a, b, c;
    a = Console.ReadLine();
    b = Console.ReadLine();
    c = Console.ReadLine();
    if (a == "vertebrado" && b=="ave" && c=="carnivoro") Console.WriteLine("aguia");
    if (a == "vertebrado" && b=="ave" && c=="onivoro") Console.WriteLine("pomba");
    if (a == "vertebrado" && b=="mamifero" && c=="onivoro") Console.WriteLine("homem");
    if (a == "vertebrado" && b=="mamifero" && c=="herbivoro") Console.WriteLine("vaca");
    if (a == "invertebrado" && b=="inseto" && c=="herbivoro") Console.WriteLine("lagarta");
    if (a == "invertebrado" && b=="inseto" && c=="hematofago") Console.WriteLine("pulga");
    if (a == "invertebrado" && b=="anelideo" && c=="hematofago") Console.WriteLine("sanguessuga");
    if (a == "invertebrado" && b=="anelideo" && c=="onivoro") Console.WriteLine("minhoca");
  }
}