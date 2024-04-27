using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubDeJogos.Models
{
    public class JogoDaAdivinhacao
    {   
        public void Menu()
        /* Esta função é responsável por toda a execução do menu do jogo, ou seja, é necessária para que o player possa
        escolher as suas próximas ações. Então, qualquer alteração pode afetar completamente a execução do jogo. 
        TENHA MUITO CUIDADO!*/
        {
            Console.WriteLine( "\n=============== MENU ===============");
            Console.WriteLine("[P] Digite 'P' caso queira que o jogo inicie");
            Console.WriteLine("[D] Digite 'D' caso queira entender como o jogo funciona");
            Console.WriteLine("[Q] Digite 'Q' caso queira voltar ao menu anterior");
            Console.Write("\nDigite a opção escolhida: ");
            string? opcao = Console.ReadLine(); // Realiza a leitura da opção que será digitada pelo jogador

            while (true)
            {
                switch (opcao) // Switch responsável pelo monitoramento do código que é lido após a execução do menu. 
                {
                    case "P" or "p": // Função que realiza a execução do jogo ao digitar a letra "P".
                        ExecucaoJogoDaAdivinhacao();
                        return;
                    case "D" or "d": // Função que demonstra as regras do jogo para o player ao digitar a letra "D"
                        Console.WriteLine("\nO príncipio do Jogo da Adivinhação baseia-se em um jogo onde a máquina idealizará um número de 0 até 5 "
                        + "e você tentará adivinhá-lo. Caso acerte, ganhará um ponto, caso contrário, a máquina ganhará um ponto. Quem tiver mais pontos em 5 rodadas, vence."); 
                        Console.WriteLine("\nAperte qualquer tecla para continuar...");
                        Console.ReadKey();
                        Menu();
                        return;
                    case "Q" or "q": // Função que permite retornar para o menu anterior que permite selecionar os jogos do HUB.
                        Console.WriteLine("Você escolheu retornar ao menu anterior.");
                        return;   
                }
            }      
        }

        public void ExecucaoJogoDaAdivinhacao()
        /*Esta é a função que realiza a execução do jogo após o jogador digitar a letra "P", então caso queira realizar qualquer alteração
        no funcionamento do jogo, será realizada nesta região do código.*/
        {
            int vitoria = 0; // Contador de Vitórias.
            int derrota = 0; // Contador de Derrotas.
                
            for (int quantidadeDeJogos = 0; quantidadeDeJogos < 5; quantidadeDeJogos++) // Loop responsável pelo funcionamento do jogo como MD5 (melhor de 5).
            {
                    Random rnd = new Random();
                    int jogadaDaCPU = rnd.Next(0, 3);
                    Console.Write("\nAdivinhe o número escolhido pela CPU: ");

                    if (int.TryParse(Console.ReadLine(), out int jogadaDoJogador) && jogadaDoJogador >= 0 && jogadaDoJogador <= 2)
                    {                  
                        if (jogadaDoJogador == jogadaDaCPU)
                        {
                            Console.WriteLine("Você acertou o número escolhido pela CPU. Você venceu esta rodada.");
                            vitoria += 1;
                        }
                        else
                        {
                            Console.WriteLine("Não foi dessa vez. A CPU venceu esta rodada!");
                            derrota += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por gentileza, digitar um valor entre 0 e 3");
                        quantidadeDeJogos--;
                    }
            }
            if (vitoria > derrota) {Console.WriteLine("Você venceu a CPU. PARABÉNS!");}
            else {Console.WriteLine ("A CPU foi mais forte. Você perdeu!");}   

            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu...");
            Console.ReadKey();
            Menu(); // Retorno ao menu de seleção do jogo.
        }
    }
}