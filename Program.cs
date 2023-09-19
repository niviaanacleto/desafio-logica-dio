using System;
namespace HeroXP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string nome;
            int xp;
            // Entrada de dados
            Console.Write("Digite o nome do herói: ");
            nome = Console.ReadLine();
            Console.Write("Digite a quantidade de experiência (XP) do herói: ");
            xp = int.Parse(Console.ReadLine());
            // Estrutura de decisão
            string nivel;
            switch (xp)
            {
                case < 1000:
                    nivel = "Ferro";
                    break;
                case >= 1001 and <= 2000:
                    nivel = "Bronze";
                    break;
                case >= 2001 and <= 5000:
                    nivel = "Prata";
                    break;
                case >= 6001 and <= 7000:
                    nivel = "Ouro";
                    break;
                case >= 7001 and <= 8000:
                    nivel = "Platina";
                    break;
                case >= 8001 and <= 9000:
                    nivel = "Ascendente";
                    break;
                case >= 9001 and <= 10000:
                    nivel = "Imortal";
                    break;
                default:
                    nivel = "Radiante";
                    break;
            }
            // Saída
            Console.WriteLine("O Herói {0} está no nível {1}", nome, nivel);
            // Perguntar se o usuário quer tentar novamente
            Console.Write("Deseja tentar novamente? (S/N) ");
            string resposta = Console.ReadLine();
            // Verificar a resposta do usuário
            if (resposta == "S" || resposta == "s")
            {
                // Retornar ao início do programa
                Main(args);
            }
            else
            {
                // Encerrar o programa
                Console.WriteLine("Até a próxima aventura!");
            }
        }
    }
}
