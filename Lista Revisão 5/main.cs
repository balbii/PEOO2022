using System;
class Program {
  public static void Main(){
    Console.WriteLine("Digite a data de hoje no formato dd/mm/aaaa:");
    string hoje = Console.ReadLine();
    Console.WriteLine("Digite sua data de nascimento no formato dd/mm/aaaa:");
    string nascimento = Console.ReadLine();
    int anos = 0; int meses = 0;
    Idade(hoje,nascimento, out anos, out meses);
    Console.WriteLine($"Você tem {anos} anos e {meses} meses de vida.");
  }
  public static double Menor(double x, double y) {
    if (x < y) return x; else return y;
  }
  public static double AreaCirculo(double raio) {
    double area = raio*raio*3.14;
    return area;
  }
  public static double Diagonal(double b, double h) {
    double diagonal = Math.Sqrt(b*b + h*h);
    return diagonal;
  }
  public static double VolumeEsfera(double r) {
    double volume = (4.0/3) * 3.14 * Math.Pow(r, 3);
    return volume;
  }
  public static double VolumeLitros(double h, double l, double p) {
    double volume = h*l*p*1000;
    return volume;
  }
  public static double Frete(double massa, double distancia) {
    return 0.01*massa*distancia;
  }
  public static void AntecessorSucessor(int x, out int antecessor, out int sucessor) {
    antecessor = x - 1;
    sucessor = x + 1;
  }
  public static int MenorInteiro(double x) {
    int i = (int) x;
    if (x==i) return i; else return i+1;
  }
  public static int Soma(int inicio, int fim) {
    int n = (fim - inicio) + 1;
    int soma = (n*(fim+inicio))/2;
    return soma;
  }
  public static string Vogais(string s) {
    string r = "";
    foreach (char c in s) {
      switch(c){
        case 'a': 
        case 'e': 
        case 'i': 
        case 'o': 
        case 'u': r += c; break;
      } 
    }
    return r;
  }
  public static string Palavra(string texto, int pos) {
    string s = texto+" ";
    while (pos > 0) {
      int indice = s.IndexOf(" ");
      s = s.Substring(indice+1);
      pos--;
    }
    int index = s.IndexOf(" ");
    s = s.Substring(0,index);
    return s;
  }
  public static string Senha(string texto) {
    string[] v = texto.Split();
    string r = "";
    foreach (string s in v) {
      int n = s.Length;
      string a = n.ToString();
      r = r + a;
    }
    return r;
  }
  public static string RemoverEspaços(string texto) {
    string[] v = texto.Split();
    string r = "";
    foreach (string s in v) {
      int n = s.Length;
      if (n != 0) r = r + s + " ";
    }
    return r;
  }
  public static string Referencia(string nome) {
    string[] v = nome.Split();
    int n = v.Length;
    int k = 1;
    string r = "";
    foreach (string s in v) {
      if (k >= n) r = s.ToUpper() + ", " + r;
      else{
        char c = s[0];
        if (Char.IsUpper(c)) {
          r = r + c + ". ";
        }
      }
      k++;
    }
    return r;
  }
  public static string UltimoDia(int mes, int ano) {
    int dia;
    if (mes == 1 ||mes == 3 ||mes == 5 ||mes == 7 ||mes == 8 ||mes == 10 ||mes == 12) dia = 31;
    else{
      if (mes == 2) {
        if (ano % 4 == 0) dia = 29;
        else dia = 28;
      }
      else dia = 30;
    }
    string d = dia.ToString();
    return d;
  }
  public static void Idade(string hoje, string nascimento, out int anos,out int meses) {
    meses = 0;
    string[] today = hoje.Split("/");
    string[] birth = nascimento.Split("/");
    
    int aa_hoje = int.Parse(today[2]);
    int aa_nasc = int.Parse(birth[2]);
    anos = aa_hoje - aa_nasc;

    int mm_hoje = int.Parse(today[1]);
    int mm_nasc = int.Parse(birth[1]);
    if (mm_nasc > mm_hoje) {
      meses = 12 - (mm_nasc - mm_hoje);
      anos--;
    }
    else if (mm_nasc < mm_hoje) {meses = mm_hoje - mm_nasc; anos--;}
    else if (mm_nasc == mm_hoje) {
      int dd_hoje = int.Parse(today[0]);
      int dd_nasc = int.Parse(birth[0]);
      if (dd_nasc < dd_hoje) {meses = 11; anos--;}
      else meses = 0;
    }
  }
}