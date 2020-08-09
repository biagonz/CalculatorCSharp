using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      //Limpa a tela ao chamr a função
      Console.Clear();
      Console.WriteLine("#### CACLULADORA ####");

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("+: Soma");
      Console.WriteLine("-: Subtração");
      Console.WriteLine("*: Divisão");
      Console.WriteLine("/: Multiplicação");
      Console.WriteLine("0: Sair");

      Console.WriteLine("-------------------");
      Console.WriteLine("Selecione uma opção: ");

      Console.Write("Opção: ");
      float op = char.Parse(Console.ReadLine());

      switch (op)
      {
        case '+': { Soma(); break; }
        case '-': { Subtracao(); break; }
        case '/': { Divisao(); break; };
        case '*': { Multiplicacao(); break; };
        case '0': {System.Environment.Exit(0); break;}
        default: Menu(); break;

      }
    }

    static void Soma()
    {
      Console.Write("Primeiro valor: ");
      //ReadLine recebe o valor no console e espera o usuário apertar o enter
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 + v2;

      Console.WriteLine("");
      //Com o $ é possível utilizar a interpolação com chaves
      Console.WriteLine($"Resultado da soma é: {resultado}");
      //Não encerra o programa após finalizar a função
      Console.ReadKey();
      Menu();
    }
    static void Subtracao()
    {
      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 - v2;
      Console.WriteLine("");
      Console.WriteLine($"Resultado da subtração é: {resultado}");
      Console.ReadKey();
      Menu();
    }
    static void Divisao()
    {
      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 / v2;
      Console.WriteLine("");
      Console.WriteLine($"Resultado da divisão é: {resultado}");
      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 * v2;
      Console.WriteLine("");
      Console.WriteLine($"Resultado da multiplição é: {resultado}");
      Console.ReadKey();
      Menu();
    }
  }
}
