using System;
class Program{
  public static void Main(){
    Console.WriteLine("digite seu nome completo:");
    string nome = Console.ReadLine();
    Console.WriteLine(Captalize(nome));
  }
  public static string Captalize(string nome){
    string[] v = nome.ToLower().Split();
    string r = "";
    foreach (string s in v) {
      switch(s) {
        case "da": case "do": case "de": case "dos": case "das":
        case "e": r = r + s + " "; break;
        case "i": r += "I "; break;
        case "ii": r += "II "; break;
        case "iii": r += "III "; break;
        case "iv": r += "IV "; break;
        default:
          if (s != "") 
            r = r + s.Substring(0, 1).ToUpper() + s.Substring(1) + " ";
        break;
      }
    }
    return r;
  }
}