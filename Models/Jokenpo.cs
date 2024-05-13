using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubDeJogos.Models
{
        
    public class Jokenpo
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
            string opcao = Console.ReadLine(); // Realiza a leitura da opção que será digitada pelo jogador

            while (true)
            {
                switch (opcao) // Switch responsável pelo monitoramento do código que é lido após a execução do menu. 
                {
                    case "P" or "p": // Função que realiza a execução do jogo ao digitar a letra "P".
                        ExecucaoJokenpo();
                        return;
                    case "D" or "d": // Função que demonstra as regras do jogo para o player ao digitar a letra "D"
                        Console.WriteLine("\nO príncipio do Jokenpô está nos seus objetos, onde cada jogador tem a opção de escolher entre Pedra, Papel e Tesoura "
                        + ", sendo que pedra vence tesoura, tesoura vence papel e papel vence pedra"); 
                        Console.WriteLine("\nAperte qualquer tecla para continuar...");
                        Console.ReadKey();
                        Menu();
                        return;
                    case "Q" or "q": // Função que permite retornar para o menu anterior que permite selecionar os jogos do HUB.
                        Console.WriteLine("Você escolheu retornar ao menu anterior.");
                        new MenuPrincipal().Menu();   
                        return;
                }
            }      
        }

        public void ExecucaoJokenpo() 
        /* Função que executa o jogo do Jokenpo, gerando tanto a jogada da CPU quanto introduzindo a jogada do jogador */
        {
            int vitoria = 0;
            int derrota = 0;
            List<string> dados = new List<string>(); // Lista onde as possíveis jogadas da CPU ficam armazenadas.
            dados.Add("Pedra");
            dados.Add("Papel");
            dados.Add("Tesoura");


            for (int quantidadeDeJogos = 0; quantidadeDeJogos < 5; quantidadeDeJogos++)
            {
                Random rnd = new Random();
                int indiceCPU = rnd.Next(0, 2); // Escolha randômica do valor.
                string escolhaCPU = dados[indiceCPU]; // Consulta na Lista
                Console.Write("\nEscolha entre Pedra, Papel e Tesoura: ");
                string escolha = Console.ReadLine();

                if (indiceCPU == 0) // Função caso a CPU tenha escolhido PEDRA
                {
                    if (escolha == "Pedra")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, EMPATE!");
                        quantidadeDeJogos--;
                    }
                    else if (escolha == "Papel")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, VITÓRIA!");
                        vitoria++;
                    }
                    else if(escolha == "Tesoura")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, DERROTA!");
                        derrota++;
                    }
                    else
                    {
                        Console.WriteLine("Você precisa escolher uma opção válida!");
                        quantidadeDeJogos--;
                    }
                }
                else if (indiceCPU == 1) // Função caso a CPU tenha escolhido PAPEL
                {
                    if (escolha == "Papel")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, EMPATE!");
                        quantidadeDeJogos--;
                    }
                    else if (escolha == "Tesoura")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, VITÓRIA!");
                        vitoria++;
                    }
                    else if(escolha == "Pedra")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, DERROTA!");
                        derrota++;
                    }
                    else
                    {
                        Console.WriteLine("Você precisa escolher uma opção válida!");
                        quantidadeDeJogos--;
                    }
                }
                if (indiceCPU == 2) // Função caso a CPU tenha escolhido TESOURA
                {
                    if (escolha == "Tesoura")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, EMPATE!");
                        quantidadeDeJogos--;
                    }
                    else if (escolha == "Pedra")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, VITÓRIA!");
                        vitoria++;
                    }
                    else if(escolha == "Papel")
                    {
                        Console.WriteLine($"A CPU escolheu {escolhaCPU} e você escolheu {escolha} logo, DERROTA!");
                        derrota++;
                    }
                    else
                    {
                        Console.WriteLine("Você precisa escolher uma opção válida!");
                        quantidadeDeJogos--;
                    }
                }
            }
            
            if (vitoria > derrota) {Console.WriteLine("\nVocê venceu a CPU. PARABÉNS!");}
            else {Console.WriteLine ("\nA CPU foi mais forte. Você perdeu!");}   

            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu...");
            Console.ReadKey();
            Menu(); // Retorno ao menu de seleção do jogo.
        }
    }
}