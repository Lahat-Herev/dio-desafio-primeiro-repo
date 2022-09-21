/*
   TODO: 
   Paulinho tem em suas mãos um novo problema. 
   Agora a sua professora lhe pediu que construísse um programa para verificar, 
   à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A. 
   Entrada
         A entrada consiste de vários casos de teste. 
         A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. 
         Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.
   Saída
         Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo. 
         4 (casos de entrada)
         
         56234523485723854755454545478690 78690 
         5434554 543 
         1243 1243 
         54 64545454545454545454545454545454554 
         Saída esperada:
         encaixa
         nao encaixa
         encaixa
         nao encaixa
*/

using System.IO;
using System.Linq;
using System;

/*
class Program 
{
    static void Main(string[] args)
    {
    int n = int.Parse(Console.ReadLine());
    string[] v;
    for (int i = 0; i < n; i++)
    {
        v = Console.ReadLine().Split(" ");
        string a = v[0];
        string b = v[1];
        if (b.Length > a.Length)
            Console.WriteLine("nao encaixa");
        else if (a.EndsWith(b))
            Console.WriteLine("encaixa");
        else
            Console.WriteLine("nao encaixa");
    }
    }
}
*/

/*
string[,] vector = new string[qt, 2] 
{ 
   {"56234523485723854755454545478690", "78690"},
   {"5434554","543"}, 
   {"1243", "1243"},
   {"54", "64545454545454545454545454545454554"} 
};
*/


Console.WriteLine("Digite a quantidade de operacoes: ");
int qt = int.Parse(Console.ReadLine());

string[,] vector = new string[qt, 2];

for (int i = 0; i < qt; i++)
{
   for (int j = 0; j < 2; j++)
   {
      vector[i, j] = Console.ReadLine();
   }
   Console.WriteLine();
}

for (int i = 0; i < qt; i++)
{
   if (vector[i, 0] == vector[i, 1]) Console.WriteLine("encaixa");
   else if (vector[i, 0].EndsWith(vector[i, 1])) Console.WriteLine("encaixa");
   else Console.WriteLine("nao encaixa");
}
