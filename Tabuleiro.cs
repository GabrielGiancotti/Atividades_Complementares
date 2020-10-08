using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projeto_Jogo_Velha
{
    class Tabuleiro
    {
        string[,] tabuleiro = new string[3, 3];
        
        //Função responsavel por definir os numeros que serao responsaveis pela marcação do X e O
        public string[,] DefinindoTabuleiro()
        {
            //DEFININDO O TABULEIRO
            tabuleiro[0, 0] = "7";
            tabuleiro[0, 1] = "8";
            tabuleiro[0, 2] = "9";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "1";
            tabuleiro[2, 1] = "2";
            tabuleiro[2, 2] = "3";

            return tabuleiro;
        }

        //Função responsavel por escrever o tabuleiro pro usuario, onde recebe no parametro o tabuleiro
        public void EscrevendoTabuleiro(string [,]tab)
        {
            Console.Clear();
            //PRIMEIRA PARTE DO TABULEIRO
            Console.WriteLine(" -------------");

            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tab[0, t]);
            }
            Console.Write(" | \n");

            //SEGUNDA PARTE DO TABULEIRO
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tab[1, t]);
            }
            Console.Write(" | \n");

            //TERCEIRA PARTE DO TABULEIRO
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tab[2, t]);
            }
            Console.Write(" | \n");

            Console.WriteLine(" -------------");
        }

        //Função responsavel por verificar se a máquina 1 "X" vai ganhar a partida, caso nao ganhe chama a funcao de movimento da máquina 2 "O", passando como parametro o tabuleiro que ira usar para validar as verificacoes 
        public void PossibilidadeGanharX(string [,]tab)
        {
            EscrevendoTabuleiro(tab);
            //POSSIBILIDADES DE GANHAR X - HORIZONTAL
            if ((tab[0, 0] == "X") && (tab[0, 1] == "X") && (tab[0, 2] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[1, 0] == "X") && (tab[1, 1] == "X") && (tab[1, 2] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[2, 0] == "X") && (tab[2, 1] == "X") && (tab[2, 2] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR X - VERTICAL
            else if ((tab[0, 0] == "X") && (tab[1, 0] == "X") && (tab[2, 0] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 1] == "X") && (tab[1, 1] == "X") && (tab[2, 1] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "X") && (tab[1, 2] == "X") && (tab[2, 2] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR X - DIAGONAL
            else if ((tab[0, 0] == "X") && (tab[1, 1] == "X") && (tab[2, 2] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "X") && (tab[1, 1] == "X") && (tab[2, 0] == "X"))
            {
                Console.WriteLine("Maquina 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            //Responsavel por verificar se tem alguma parte do tabuleiro sem preencher
            else if ((tab[0, 0] == "7") || (tab[0, 1] == "8") || (tab[0, 2] == "9") || (tab[1, 0] == "4") || (tab[1, 1] == "5") || (tab[1, 2] == "6") || (tab[2, 0] == "1") || (tab[2, 1] == "2") || (tab[2, 2] == "3"))
            {
                Jogador MyPlayer = new Jogador();
                MyPlayer.MovimentoMaquinaO(tab);
            }
            //Caso o tabuleiro esteja preenchido, essa verificação é responsavel por mostrar que o jogo empatou
            else
            {
                Console.WriteLine("Jogo Empatou!!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        //Função responsavel por verificar se a máquina 2 "O" vai ganhar a partida, caso nao ganhe chama a funcao de movimento da máquina 1"X", passando como parametro o tabuleiro que ira usar para validar as verificacoes 
        public void PossibilidadeGanharO(string [,]tab)
        {
            EscrevendoTabuleiro(tab);
            //POSSIBILIDADES DE GANHAR O - HORIZONTAL
            if ((tab[0, 0] == "O") && (tab[0, 1] == "O") && (tab[0, 2] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[1, 0] == "O") && (tab[1, 1] == "O") && (tab[1, 2] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[2, 0] == "O") && (tab[2, 1] == "O") && (tab[2, 2] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR O - VERTICAL
            else if ((tab[0, 0] == "O") && (tab[1, 0] == "O") && (tab[2, 0] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 1] == "O") && (tab[1, 1] == "O") && (tab[2, 1] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "O") && (tab[1, 2] == "O") && (tab[2, 2] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR O - DIAGONAL
            else if ((tab[0, 0] == "O") && (tab[1, 1] == "O") && (tab[2, 2] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "O") && (tab[1, 1] == "O") && (tab[2, 0] == "O"))
            {
                Console.WriteLine("Máquina 2 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            //Responsavel por verificar se tem alguma parte do tabuleiro sem preencher
            else if ((tab[0, 0] == "7") || (tab[0, 1] == "8") || (tab[0, 2] == "9") || (tab[1, 0] == "4") || (tab[1, 1] == "5") || (tab[1, 2] == "6") || (tab[2, 0] == "1") || (tab[2, 1] == "2") || (tab[2, 2] == "3"))
            {
                Jogador MyPlayer = new Jogador();
                MyPlayer.MovimentoMaquinaX(tab);
            }
            //Caso o tabuleiro esteja preenchido, essa verificação é responsavel por mostrar que o jogo empatou
            else
            {
                Console.WriteLine("Jogo Empatou!!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
        //Função responsavel por verificar se a jogador "X" vai ganhar a partida, caso nao ganhe chama a funcao de movimento da máquina "O", passando como parametro o tabuleiro que ira usar para validar as verificacoes e uma variavel booleana para verificar se a partida esta sendo jogado pelo usuario
        public void PossibilidadeGanharX(string [,] tab, bool playerjogando)
        {
            EscrevendoTabuleiro(tab);
            //POSSIBILIDADES DE GANHAR X - HORIZONTAL
            if ((tab[0, 0] == "X") && (tab[0, 1] == "X") && (tab[0, 2] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[1, 0] == "X") && (tab[1, 1] == "X") && (tab[1, 2] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[2, 0] == "X") && (tab[2, 1] == "X") && (tab[2, 2] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR X - VERTICAL
            else if ((tab[0, 0] == "X") && (tab[1, 0] == "X") && (tab[2, 0] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 1] == "X") && (tab[1, 1] == "X") && (tab[2, 1] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "X") && (tab[1, 2] == "X") && (tab[2, 2] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR X - DIAGONAL
            else if ((tab[0, 0] == "X") && (tab[1, 1] == "X") && (tab[2, 2] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "X") && (tab[1, 1] == "X") && (tab[2, 0] == "X"))
            {
                Console.WriteLine("Jogador 1 Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            //Responsavel por verificar se tem alguma parte do tabuleiro sem preencher
            else if ((tab[0,0] == "7") || (tab[0, 1] == "8") || (tab[0, 2] == "9") || (tab[1, 0] == "4") || (tab[1, 1] == "5") || (tab[1, 2] == "6") || (tab[2, 0] == "1") || (tab[2, 1] == "2") || (tab[2, 2] == "3"))
            {
                Jogador MyPlayer = new Jogador();
                MyPlayer.MovimentoMaquinaO(tab, playerjogando);
            }
            //Caso o tabuleiro esteja preenchido, essa verificação é responsavel por mostrar que o jogo empatou
            else
            {
                Console.WriteLine("Jogo Empatou!!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        //Função responsavel por verificar se a maquina "O" vai ganhar a partida, caso nao ganhe chama a funcao de movimento do jogador "X", passando como parametro o tabuleiro que ira usar para validar as verificacoes e uma variavel booleana para verificar se a partida esta sendo jogado pelo usuario
        public void PossibilidadeGanharO(string [,]tab, bool playerjogando)
        {
            EscrevendoTabuleiro(tab);
            //POSSIBILIDADES DE GANHAR O - HORIZONTAL
            if ((tab[0, 0] == "O") && (tab[0, 1] == "O") && (tab[0, 2] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[1, 0] == "O") && (tab[1, 1] == "O") && (tab[1, 2] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[2, 0] == "O") && (tab[2, 1] == "O") && (tab[2, 2] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR O - VERTICAL
            else if ((tab[0, 0] == "O") && (tab[1, 0] == "O") && (tab[2, 0] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 1] == "O") && (tab[1, 1] == "O") && (tab[2, 1] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "O") && (tab[1, 2] == "O") && (tab[2, 2] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            //POSSIBLIDADES DE GANHAR O - DIAGONAL
            else if ((tab[0, 0] == "O") && (tab[1, 1] == "O") && (tab[2, 2] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else if ((tab[0, 2] == "O") && (tab[1, 1] == "O") && (tab[2, 0] == "O"))
            {
                Console.WriteLine("Máquina Ganhou!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            //Responsavel por verificar se tem alguma parte do tabuleiro sem preencher
            else if ((tab[0, 0] == "7") || (tab[0, 1] == "8") || (tab[0, 2] == "9") || (tab[1, 0] == "4") || (tab[1, 1] == "5") || (tab[1, 2] == "6") || (tab[2, 0] == "1") || (tab[2, 1] == "2") || (tab[2, 2] == "3"))
            {
                Jogador MyPlayer = new Jogador();
                MyPlayer.MovimentoJogador(tab, playerjogando);
            }
            //Caso o tabuleiro esteja preenchido, essa verificação é responsavel por mostrar que o jogo empatou
            else
            {
                Console.WriteLine("Jogo Empatou!!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
    }
}
