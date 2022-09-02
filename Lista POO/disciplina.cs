using System;
class Program {
  public static void Main(){
    Disciplina peoo = new Disciplina();
    peoo.nome = "Programação Estruturada e Orientada a Objetos";
    peoo.nota1 = 70;
    peoo.nota2 = 65;
    peoo.nota3 = 75;
    peoo.nota4 = 30;
    peoo.nota_f = 80;
    Console.WriteLine(peoo.MediaParcial());
    Console.WriteLine(peoo.MediaFinal());
  }
}
class Disciplina {
  public string nome;
  public int nota1;
  public int nota2;
  public int nota3;
  public int nota4;
  public int nota_f;
  public double MediaParcial() {
    double media = (nota1*2 + nota2*2 + nota3*3 + nota4*3)/10.0;
    return media;
  }
  public double MediaFinal(){
    double media = MediaParcial();
    if (media > 60) return media;
    else return (media + nota_f)/2.0;
  }
}