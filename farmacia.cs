using System;

class MainClass {
  public static void Main (string[] args) 
  {

//variaveis
float preco = 45.00f;
int taxa = 5;
float off = 2.5f;
float entrega = 1.5f;

var total = (preco - off) + taxa;

Console.Write(total);

}
}