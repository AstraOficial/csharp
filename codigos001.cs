using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Hello();
    Calculo();
    Farmary(40, 18, 5);
  }

static void Hello()
{
  Console.Write("Hello World");
}

static void Calculo ()
{
    Console.WriteLine(4 * 5);
    Console.WriteLine(7 / 4);
    Console.WriteLine(44 + 6);
}

static void Farmary (float preco, float taxa, int off)
{

Console.WriteLine(preco);
Console.WriteLine(taxa);
Console.WriteLine(off);

}

}