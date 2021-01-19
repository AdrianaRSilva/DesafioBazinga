using System;

namespace DesafioBazinga
{
    class Desafio
    {
        static void Main()
        {
            int Teste;
            string Sheldon, Raj, Mensagem;
            Int32.TryParse(Console.ReadLine(), out Teste);

            for (int i = 0; i < Teste; i++)
            {
                string[] linha = Console.ReadLine().Split(" ");
                Sheldon = linha[0];
                Raj = linha[1];
                Mensagem = Vencedor(Sheldon, Raj);
                Console.WriteLine($"Caso #{i + 1}: {Mensagem}");
            }
        }
        public static string Vencedor(string s, string r)
        {
            string Mensagem = null;
            if (s == r)
            {
                Mensagem = "De novo!";
            }
            else
            {
                if (s == "tesoura" && (r == "papel" || r == "lagarto"))
                {
                    Mensagem = "Bazinga!";
                }
                else if (s == "papel" && (r == "pedra" || r == "Spock"))
                {
                    Mensagem = "Bazinga!";
                }
                else if (s == "pedra" && (r == "lagarto" || r == "tesoura"))
                {
                    Mensagem = "Bazinga!";
                }
                else if (s == "lagarto" && (r == "Spock" || r == "papel"))
                {
                    Mensagem = "Bazinga!";
                }
                else if (s == "Spock" && (r == "tesoura" || r == "pedra"))
                {
                    Mensagem = "Bazinga!";
                }
                else
                {
                    Mensagem = "Raj trapaceou!";
                }
            }
            return Mensagem;
        }


    }
}