//Pacotes do c sharp
using System; //manipular o sistam operacional
using System.Text; //manipular textos
using System.IO; //manipular arquivos
using System.Net; //conexão com a internet

namespace estudos000
{ //Nomear Blocos

 class Program //Inicio da classe
 {

static void Main(string[] args)
{

/* tipos de variaveis
var       variavel comum
int       inteiro -156 ou 32334
float     numero flutuante   -15.6f ou 1.23f
double    decimal
bool      booler     true ou false
string    texto comum  "texto"
char      uma caractere    't'
*/

//variavel do ambiente
var meutexto = "Olá Mundo";
int idade = 19;
string nome = "Alan";
char letra = 'a';
bool casado = true;
float ano = 2020f;

//trocar valor da variavel
meutexto = "Troquei o valor da string ";
idade = 0;
nome = "";
ano = 0.0f;

//escreva na tela
Console.WriteLine(meutexto);
Console.WriteLine("Linguagem C# ");

//constantes não tem valores alterados
const string pl = "tests";
const int pls = 444;
const float pi = 3.14f;
const bool manuntencao = false;

//interação saida e entrada de dados
var nomes = "";
Console.Write("Digite seu nome: ");
nomes = Console.ReadLine();

/*
* multiplicar
- diminuir
/ dividir
== igual
= recebe
+ somar
// resto
> maior que
< menor que
<= menor ou igual
>= maior ou igual

&& e
|| ou
*/

//calculos
int av1 = 9 + 7;
int av2 = 3 / 3;
int av3 = (9 + 1) * 10;
int av4 = (50 / 5) + 10;

Console.WriteLine(av1);
Console.WriteLine(av2);
Console.WriteLine(av3);
Console.WriteLine(av4);

//true ou false?
Console.WriteLine(4 > 1);
Console.WriteLine(4 < 1);
Console.WriteLine(90 == 90);
Console.WriteLine(80 == 90);

//Algoritimo de if e else usdando &&
var sexo = "homem";
var idade = 17;

if (sexo == "mulher" && idade >= 18){
  Console.Write("Entrada é R$50,00");
}

else if (sexo == "mulher" && idade <= 17){
  Console.Write("Entrada é R$125,00");
}

else if (sexo == "homem" && idade <= 17){
  Console.Write("Entrada é R$85,00");
}

else if (sexo == "homem" && idade >= 18){
  Console.Write("Entrada é R$150,00");
}

else {
  Console.Write("VC digitou algo invalido");
} //final da condição

//Condição usando ||
var sexo = "homem";
var idade = 17;

if (sexo == "mulher" || idade >= 18){
  Console.Write("Entrada é R$50,00");
}

else if (sexo == "criança" || idade <= 17){
  Console.Write("Entrada é R$125,00");
}

else {
  Console.Write("VC digitou algo invalido");
} //final da condição




} //fim da classe
} //fim da função Main
} //fim do namespace