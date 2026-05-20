using GestaoDeEquipamentos.ConsoleApp.Domínio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class TelaEquipamento
{
    public RepositorioEquipamento repositorioEquipamento;
    public string? ObterOpcaoMenu()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Controle de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar Equipamento");
        Console.WriteLine("2 - Editar Equipamento");
        Console.WriteLine("3 - Excluir Equipamento");
        Console.WriteLine("4 - Visualizar Equipamentos");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }
    public void Cadastrar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Cadastro de Equipamento");
        Console.WriteLine("---------------------------------");
        Console.Write("Digite o nome do equipamento: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço de aquisiçao do equipamento: ");
        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricaçao do equipamento: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        Equipamento equipamento = new Equipamento();
        equipamento.nome = nome;
        equipamento.precoAquisicao = precoAquisicao;
        equipamento.dataFabricacao = dataFabricacao;

        repositorioEquipamento.Cadastar(equipamento);

        Console.WriteLine($"O equipamento {equipamento.nome} foi cadastrado com sucesso!");
        Console.ReadLine();
    }
    public void Editar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Ediçao de Equipamento");
        Console.WriteLine("---------------------------------");

        Equipamento[] equipamentosSalvos = repositorioEquipamento.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisiçao", "Data de Fabricaçao"
        );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite o id do registro que deseja editar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do equipamento: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço de aquisiçao do equipamento: ");
        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricaçao do equipamento");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        Equipamento equipamentoAtualizado = new Equipamento();
        equipamentoAtualizado.nome = nome;
        equipamentoAtualizado.precoAquisicao = precoAquisicao;
        equipamentoAtualizado.dataFabricacao = dataFabricacao;

        repositorioEquipamento.Editar(idSelecionado, equipamentoAtualizado);

        Console.WriteLine($"O equipamento {nome} foi editado com sucesso!");
        Console.ReadLine();
    }

    public void Excluir()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Exclusao de Equipamentos");
        Console.WriteLine("---------------------------------");

        Equipamento[] equipamentosSalvos = repositorioEquipamento.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisiçao", "Data de Fabricaçao"
            );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite o id do registro que deseja excluir: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        repositorioEquipamento.Excluir(idSelecionado);

        Console.WriteLine($"O equipamento foi excluído com sucesso!");
        Console.ReadLine();
    }

    public void VisualizarTodos()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Visualizaçao de Equipamentos");
        Console.WriteLine("---------------------------------");

        Equipamento[] equipamentosSalvos = repositorioEquipamento.SelecionarTodos();

        //tabela do console
        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisiçao", "Data de Fabricaçao"
            );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}