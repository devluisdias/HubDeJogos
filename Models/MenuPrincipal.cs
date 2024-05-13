using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubDeJogos.Models
{
    public class MenuPrincipal
    {
        public void Menu()
        {
            Console.WriteLine("\n=============== MENU ===============");
            Console.WriteLine("[1] Jogo da Adivinhação");
            Console.WriteLine("[2] Pedra, Papel e Tesoura");
            Console.WriteLine("[3] Jogo da Velha");
            Console.WriteLine("[4] Voltar ao Menu Principal");

            Console.Write("\nDigite a opção escolhida: ");
            string opcaoMenu = Console.ReadLine();

            switch (opcaoMenu)
            {
                case "1":
                    JogoDaAdivinhacao jogoDaAdivinhacao = new JogoDaAdivinhacao();
                    jogoDaAdivinhacao.Menu();
                    return;
                case "2":
                    Jokenpo jokenpo = new Jokenpo();
                    jokenpo.Menu();
                    return;
                case "3":
                    Console.WriteLine("Jogo em processo de implementação");
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    return;
                case "4":
                    return;
            }
        }
        
    }
}