using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projeto_Jogo_Velha
{
    class Jogador
    {
        int jogada1, jogadamaquina, jogadamaquina1;
        bool verificarmovimento = false, verificaplayer = true;
        Random numrandom = new Random();

        //Função responsavel por pegar e aplicar os movimentos do usuario no tabuleiro e depois chamar a função para verificar se o jogador é o vencedor, passando como parametro o tabuleiro e uma variavel booleana para verificar se o usuario esta jogando
        public void MovimentoJogador(string [,]tabuleiro, bool playerjogando)
        {
            verificarmovimento = false;
            Tabuleiro MyTab = new Tabuleiro();
            MyTab.EscrevendoTabuleiro(tabuleiro);

            while (verificarmovimento == false)
            {
                Console.Write("Vez do Jogador 1: ");
                jogada1 = int.Parse(Console.ReadLine());

                //PARTE SUPERIOR DO TABULEIRO - jogador 1 "X".
                if (jogada1 == 7 && tabuleiro[0, 0] == "7")
                {
                    tabuleiro[0, 0] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else if (jogada1 == 8 && tabuleiro[0, 1] == "8")
                {
                    tabuleiro[0, 1] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else if (jogada1 == 9 && tabuleiro[0, 2] == "9")
                {
                    tabuleiro[0, 2] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }

                //PARTE CENTRAL DO TABULEIRO - jogador 1 "X".
                else if (jogada1 == 4 && tabuleiro[1, 0] == "4")
                {
                    tabuleiro[1, 0] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else if (jogada1 == 5 && tabuleiro[1, 1] == "5")
                {
                    tabuleiro[1, 1] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else if (jogada1 == 6 && tabuleiro[1, 2] == "6")
                {
                    tabuleiro[1, 2] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }

                //PARTE INFERIO DO TABULEIRO - jogador 1 "X".
                else if (jogada1 == 1 && tabuleiro[2, 0] == "1")
                {
                    tabuleiro[2, 0] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else if (jogada1 == 2 && tabuleiro[2, 1] == "2")
                {
                    tabuleiro[2, 1] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else if (jogada1 == 3 && tabuleiro[2, 2] == "3")
                {
                    tabuleiro[2, 2] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro, verificaplayer);
                }
                else
                {
                    MovimentoJogador(tabuleiro, playerjogando);
                }
            }            
        }

        //Função responsavel por pegar e aplicar os movimentos da máquina no tabuleiro e depois chamar a função para verificar se a máquina "X" foi vencedora, passando o tabuleiro como parametro
        public void MovimentoMaquinaX(string [,]tabuleiro)
        {
            verificarmovimento = false;
            Tabuleiro MyTab = new Tabuleiro();
            MyTab.EscrevendoTabuleiro(tabuleiro);
            while (verificarmovimento == false)
            {
                Console.Write("vez da máquina 1: ");
                jogadamaquina = numrandom.Next(1, 9);
                Thread.Sleep(1000);
                
                //PARTE SUPERIOR DO TABULEIRO - jogador 1 "X".
                if (jogadamaquina == 7 && tabuleiro[0, 0] == "7")
                {
                    tabuleiro[0, 0] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else if (jogadamaquina == 8 && tabuleiro[0, 1] == "8")
                {
                    tabuleiro[0, 1] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else if (jogadamaquina == 9 && tabuleiro[0, 2] == "9")
                {
                    tabuleiro[0, 2] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }

                //PARTE CENTRAL DO TABULEIRO - jogador 1 "X".
                else if (jogadamaquina == 4 && tabuleiro[1, 0] == "4")
                {
                    tabuleiro[1, 0] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else if (jogadamaquina == 5 && tabuleiro[1, 1] == "5")
                {
                    tabuleiro[1, 1] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else if (jogadamaquina == 6 && tabuleiro[1, 2] == "6")
                {
                    tabuleiro[1, 2] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }

                //PARTE INFERIO DO TABULEIRO - jogador 1 "X".
                else if (jogadamaquina == 1 && tabuleiro[2, 0] == "1")
                {
                    tabuleiro[2, 0] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else if (jogadamaquina == 2 && tabuleiro[2, 1] == "2")
                {
                    tabuleiro[2, 1] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else if (jogadamaquina == 3 && tabuleiro[2, 2] == "3")
                {
                    tabuleiro[2, 2] = "X";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharX(tabuleiro);
                }
                else
                {
                    MovimentoMaquinaX(tabuleiro);
                }
            }
        }

        //Função responsavel por pegar e aplicar os movimentos da máquina no tabuleiro e depois chamar a função para verificar se a máquina "O" foi vencedora, passando o tabuleiro como parametro
        public void MovimentoMaquinaO(string[,] tabuleiro)
        {
            verificarmovimento = false;
            Tabuleiro MyTab = new Tabuleiro();
            MyTab.EscrevendoTabuleiro(tabuleiro);
            while (verificarmovimento == false)
            {
                Console.Write("vez da máquina 2: ");
                jogadamaquina1 = numrandom.Next(1, 9);
                Thread.Sleep(1000);

                //PARTE SUPERIOR DO TABULEIRO - maquina 2 "O".
                if (jogadamaquina1 == 7 && tabuleiro[0, 0] == "7")
                {
                    tabuleiro[0, 0] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else if (jogadamaquina1 == 8 && tabuleiro[0, 1] == "8")
                {
                    tabuleiro[0, 1] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else if (jogadamaquina1 == 9 && tabuleiro[0, 2] == "9")
                {
                    tabuleiro[0, 2] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }

                //PARTE CENTRAL DO TABULEIRO - maquina 2 "O".
                else if (jogadamaquina1 == 4 && tabuleiro[1, 0] == "4")
                {
                    tabuleiro[1, 0] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else if (jogadamaquina1 == 5 && tabuleiro[1, 1] == "5")
                {
                    tabuleiro[1, 1] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else if (jogadamaquina1 == 6 && tabuleiro[1, 2] == "6")
                {
                    tabuleiro[1, 2] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }

                //PARTE INFERIO DO TABULEIRO - maquina 2 "O".
                else if (jogadamaquina1 == 1 && tabuleiro[2, 0] == "1")
                {
                    tabuleiro[2, 0] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else if (jogadamaquina1 == 2 && tabuleiro[2, 1] == "2")
                {
                    tabuleiro[2, 1] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else if (jogadamaquina1 == 3 && tabuleiro[2, 2] == "3")
                {
                    tabuleiro[2, 2] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro);
                }
                else
                {
                    MovimentoMaquinaO(tabuleiro);
                }
            }
        }

        //Função responsavel por pegar e aplicar os movimentos da no tabuleiro e depois chamar a função para verificar se a máquina é a vencedora, passando como parametro o tabuleiro e uma variavel booleana para verificar se o usuario esta na partida
        public void MovimentoMaquinaO(string[,] tabuleiro, bool playerjogando)
        {
            verificarmovimento = false;
            Tabuleiro MyTab = new Tabuleiro();
            MyTab.EscrevendoTabuleiro(tabuleiro);
            while (verificarmovimento == false)
            {
                Console.Write("vez da máquina 2: ");
                jogadamaquina1 = numrandom.Next(1, 9);
                Thread.Sleep(1000);

                //PARTE SUPERIOR DO TABULEIRO - maquina 2 "O".
                if (jogadamaquina1 == 7 && tabuleiro[0, 0] == "7")
                {
                    tabuleiro[0, 0] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else if (jogadamaquina1 == 8 && tabuleiro[0, 1] == "8")
                {
                    tabuleiro[0, 1] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else if (jogadamaquina1 == 9 && tabuleiro[0, 2] == "9")
                {
                    tabuleiro[0, 2] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }

                //PARTE CENTRAL DO TABULEIRO - maquina 2 "O".
                else if (jogadamaquina1 == 4 && tabuleiro[1, 0] == "4")
                {
                    tabuleiro[1, 0] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else if (jogadamaquina1 == 5 && tabuleiro[1, 1] == "5")
                {
                    tabuleiro[1, 1] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else if (jogadamaquina1 == 6 && tabuleiro[1, 2] == "6")
                {
                    tabuleiro[1, 2] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }

                //PARTE INFERIO DO TABULEIRO - maquina 2 "O".
                else if (jogadamaquina1 == 1 && tabuleiro[2, 0] == "1")
                {
                    tabuleiro[2, 0] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else if (jogadamaquina1 == 2 && tabuleiro[2, 1] == "2")
                {
                    tabuleiro[2, 1] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else if (jogadamaquina1 == 3 && tabuleiro[2, 2] == "3")
                {
                    tabuleiro[2, 2] = "O";
                    verificarmovimento = true;
                    MyTab.PossibilidadeGanharO(tabuleiro, verificaplayer);
                }
                else
                {
                    MovimentoMaquinaO(tabuleiro, verificaplayer);
                }
            }
        }
    }
}
