using System;

namespace Projeto_Jogo_Velha
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            string[,] tab = new string[3, 3];
            bool verificaplayer = true;
            Tabuleiro MyTab = new Tabuleiro();
            Jogador MyPlayer = new Jogador();
            
            Console.WriteLine("Digite uma opção para jogar o jogo da velha: ");
            Console.WriteLine("1- Player contra a máquina");
            Console.WriteLine("2- Máquina contra a máquina");
            op = int.Parse(Console.ReadLine());
            tab = MyTab.DefinindoTabuleiro();

            //Menu responsavel por verificar o usuario quer jogar contra a maquina, ou a máquinar jogar contra ela mesma.
            if (op == 1) //Opção responsavel por fazer que o player jogue contra a máquina
            {     
                MyPlayer.MovimentoJogador(tab, verificaplayer);
            }
            else if(op == 2) //Opção responsavel por fazer que a máquina jogue ela mesma
            {
                MyPlayer.MovimentoMaquinaX(tab);
            }
            else //Verificação responsavel por não deixar o usuario digitar uma opção invalida
            {
                Console.WriteLine("Opcao Invalida!!");
            }

            Console.ReadKey();
        }
    }
}
