namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class TelaPrincipal
{
    public string? ObterOpcaoMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestao de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Gestao de Equipamentos");
        Console.WriteLine("2 - Controle de Chamados");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

        return opcaoMenuPrincipal;
    }
}