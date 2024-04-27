using HubDeJogos.Models;

JogoDaAdivinhacao jogoDaAdivinhacao = new JogoDaAdivinhacao();
Jokenpo jokenpo = new Jokenpo();

Console.WriteLine( "\n=============== MENU ===============");
Console.WriteLine("[1] Jogo da Adivinhação");
Console.WriteLine("[2] Pedra, Papel e Tesoura");
Console.WriteLine("[3] Jogo da Velha");
Console.Write("\nDigite a opção escolhida: ");
string? opcaoMenuPrincipal = Console.ReadLine();

switch (opcaoMenuPrincipal)
{
  case "1":
    jogoDaAdivinhacao.Menu();
    return;
  case "2":
    jokenpo.Menu();
    return;
}
