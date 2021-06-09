using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            // variaveis
            string S_Resul_valor = "q";
            int Sor_valor1;
            int Sor_valor2;
            int exercicio = 1;
            int Int_Resul_valor2 = 0;
            int Int_Resul_valor = 0;
            int Dicas = 0;
            int Acertos = 0;
            int Erros = 0;
            float Pontos = 0;
            Random num = new Random();
            Console.Title = "Lista Exercicios-Contas de vezes. by Otávio";
            Console.BackgroundColor = ConsoleColor.Gray;
        Trocar:
            Sor_valor1 = num.Next(1000);
            Sor_valor2 = num.Next(1000);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            goto inicio;
        Acerto:
            Sor_valor1 = num.Next(1000);
            Sor_valor2 = num.Next(1000);
            Acertos = Acertos + 1;
            exercicio = exercicio + 1;
            Pontos = Pontos + 20f;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (Int_Resul_valor2 == Sor_valor1 + Sor_valor2)
            {
                goto Trocar;
            }
                goto inicio;
        Errou:
            Erros = Erros + 1;
            Pontos = Pontos - 10f;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            goto inicio;
        Dica:
            int Dica_Resultado = Sor_valor1 + Sor_valor2;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("O valor é " + Dica_Resultado + ".");
            Console.Write("Aperte Enter para voltar.");
            Console.ReadKey(true);
            Pontos = Pontos - 10f;
            Dicas = Dicas + 1;
            goto inicio;
        inicio:
            if (Sor_valor1 == 0 || Sor_valor2 == 0)
            {
                goto Trocar;
            }
            S_Resul_valor = "q";
            //Painel Usuario
            Console.Clear();
            Console.WriteLine("[=======================================]");
            Console.WriteLine("[");
            Console.WriteLine("[Exercicio " + exercicio);
            Console.WriteLine($"[Pontos:{Pontos}");
            Console.WriteLine($"[Acertos:{Acertos}\n[Erros:{Erros}\n[Dicas:{Dicas}");
            Console.WriteLine("[");
            Console.WriteLine("[Aperte 'D' para dicas.");
            Console.WriteLine("[Aperte 'R' para resetar.");
            Console.WriteLine("[");
            Console.WriteLine($"[Quanto é {Sor_valor1} + {Sor_valor2} ?");
            Console.WriteLine("[=======================================]");
            Console.Write("[Resultado:");
            S_Resul_valor = Console.ReadLine();

            if (S_Resul_valor.ToLower() == "r")
            {
                exercicio = 1;
                Dicas = 0;
                Acertos = 0;
                Erros = 0;
                Pontos = 0;
                goto inicio;
            }
            if (S_Resul_valor.ToLower().Contains("'") || S_Resul_valor.ToLower().Contains("~") || S_Resul_valor.ToLower().Contains("´") || S_Resul_valor.ToLower().Contains("[") || S_Resul_valor.ToLower().Contains("]") || S_Resul_valor.ToLower().Contains(":") || S_Resul_valor.ToLower().Contains(";") || S_Resul_valor.ToLower().Contains(".") || S_Resul_valor.ToLower().Contains(",") || S_Resul_valor.ToLower().Contains(".") || S_Resul_valor.ToLower().Contains("+") || S_Resul_valor.ToLower().Contains("-") || S_Resul_valor.ToLower().Contains("*") || S_Resul_valor.ToLower().Contains("/") || S_Resul_valor.ToLower().Contains("q") || S_Resul_valor.ToLower().Contains("w") || S_Resul_valor.ToLower().Contains("e") || S_Resul_valor.ToLower().Contains("r") || S_Resul_valor.ToLower().Contains("t") || S_Resul_valor.ToLower().Contains("y") || S_Resul_valor.ToLower().Contains("u") || S_Resul_valor.ToLower().Contains("i") || S_Resul_valor.ToLower().Contains("o") || S_Resul_valor.ToLower().Contains("p") || S_Resul_valor.ToLower().Contains("a") || S_Resul_valor.ToLower().Contains("s") || S_Resul_valor.ToLower().Contains("d") || S_Resul_valor.ToLower().Contains("f") || S_Resul_valor.ToLower().Contains("g") || S_Resul_valor.ToLower().Contains("h") || S_Resul_valor.ToLower().Contains("j") || S_Resul_valor.ToLower().Contains("k") || S_Resul_valor.ToLower().Contains("l") || S_Resul_valor.ToLower().Contains("ç") || S_Resul_valor.ToLower().Contains("z") || S_Resul_valor.ToLower().Contains("x") || S_Resul_valor.ToLower().Contains("c") || S_Resul_valor.ToLower().Contains("v") || S_Resul_valor.ToLower().Contains("b") || S_Resul_valor.ToLower().Contains("n") || S_Resul_valor.ToLower().Contains("m"))
            {
                if (S_Resul_valor.ToLower() == "d")
                {
                    goto Dica;
                }
                else
                {
                    goto inicio;
                }
            }
            if (S_Resul_valor.ToLower().Contains("0") || S_Resul_valor.ToLower().Contains("9") || S_Resul_valor.ToLower().Contains("8") || S_Resul_valor.ToLower().Contains("7") || S_Resul_valor.ToLower().Contains("6") || S_Resul_valor.ToLower().Contains("5") || S_Resul_valor.ToLower().Contains("4") || S_Resul_valor.ToLower().Contains("3") || S_Resul_valor.ToLower().Contains("2") || S_Resul_valor.ToLower().Contains("1"))
            {
                Int_Resul_valor = Convert.ToInt32($"{S_Resul_valor}");
                Int_Resul_valor2 = Int_Resul_valor;
                if (Int_Resul_valor2 == Sor_valor1 + Sor_valor2)
                {
                    goto Acerto;
                }
                else if (Int_Resul_valor2 != Sor_valor1 + Sor_valor2)
                {
                    goto Errou;
                }
            }
            goto inicio;
        }
    }
}
