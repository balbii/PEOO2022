using System;
class Program {
  public static void Main() {
    Disciplina design = new Disciplina();
    design.SetNome("Design Web");
    design.SetNota1(65);
    design.SetNota2(65);
    design.SetNota3(65);
    design.SetNota4(20);
    design.SetNota_f(80);
    Console.WriteLine(design.MediaParcial());
    Console.WriteLine(design.MediaFinal());
  }
}
class Disciplina {
  private string nome;
  private double nota1, nota2, nota3, nota4, nota_f;
  public void SetNome(string s){
    int tamanho = s.Length;
    if (tamanho < 20) nome = s;
    else nome = "tamanho excedido";
  }
  //Set
  public void SetNota1(double x) {
    if (x > 0) nota1 = x; }
    public void SetNota2(double x) {
    if (x > 0) nota2 = x; }
    public void SetNota3(double x) {
    if (x > 0) nota3 = x; }
  public void SetNota4(double x) {
    if (x > 0) nota4 = x; }
  public void SetNota_f(double x) {
    if (x > 0) nota_f = x; }
  //Get
  public double GetNota1() {
    return nota1; }
  public double GetNota2() {
    return nota2; }
  public double GetNota3() {
    return nota3; }
  public double GetNota4() {
    return nota4; }
  public double GetNota_f() {
    return nota_f; }
  //Methods
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