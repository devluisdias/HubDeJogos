using HubDeJogos.Models;

while (true)
{
Console.WriteLine( "\n=============== MENU ===============");
Console.WriteLine("[I] Iniciar");
Console.WriteLine("[S] Sair");
Console.Write("\nDigite a opção escolhida: ");
string opcaoMenuPrincipal = Console.ReadLine();

  switch (opcaoMenuPrincipal.ToUpper())
  {
    case "I":
      MenuPrincipal menuInicial = new MenuPrincipal();
      menuInicial.Menu();
      break;
    case "S":
      Console.WriteLine("Aplicação Finalizada!");
      return;
    default:
      Console.WriteLine("Digite um valor válido!");
      Console.WriteLine("Pressione qualquer tecla para continuar:");
      Console.ReadKey();
      break;
  }
}
