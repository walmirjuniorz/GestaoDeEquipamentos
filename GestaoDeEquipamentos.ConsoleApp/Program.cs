using GestaoDeEquipamentos.ConsoleApp.Domínio;

int contadorIdsEquipamentos = 1;
Equipamento[] equipamentosSalvos = new Equipamento[100];

int contadosIdsChamados = 1;
Chamado[] chamadosSalvos = new Chamado[100];

// Criacao de Dados teste
Equipamento equipamentoTeste = new Equipamento();
equipamentoTeste.id = contadorIdsEquipamentos++;
equipamentoTeste.nome = "Notebook";
equipamentoTeste.precoAquisicao = 2000;
equipamentoTeste.dataFabricacao = DateTime.Parse("02/02/2020");

equipamentosSalvos[0] = equipamentoTeste;

while (true)
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

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenuPrincipal == "1")
    {
        while (true)
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

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            // Operacoes CRUD - Create, Retrieve, Update, Delete

            if (opcaoMenu == "1")

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
                equipamento.id = contadorIdsEquipamentos++;
                equipamento.nome = nome;
                equipamento.precoAquisicao = precoAquisicao;
                equipamento.dataFabricacao = dataFabricacao;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    if (equipamentosSalvos[i] == null)
                        equipamentosSalvos[i] = equipamento;
                    break;
                }

                Console.WriteLine($"O equipamento {equipamento.nome} foi cadastrado com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "2")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ediçao de Equipamento");
                Console.WriteLine("---------------------------------");

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

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentoSelecionado.nome = nome;
                        equipamentoSelecionado.precoAquisicao = precoAquisicao;
                        equipamentoSelecionado.dataFabricacao = dataFabricacao;
                        break;
                    }
                }
                Console.WriteLine($"O equipamento {nome} foi editado com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "3")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Exclusao de Equipamentos");
                Console.WriteLine("---------------------------------");

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

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentosSalvos[i] = null;
                        break;
                    }
                }
                Console.WriteLine($"O equipamento foi excluído com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "4")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Visualizaçao de Equipamentos");
                Console.WriteLine("---------------------------------");

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
    }

    else if (opcaoMenuPrincipal == "2")
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Controle de Chamados");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Editar Chamado");
            Console.WriteLine("3 - Excluir Chamado");
            Console.WriteLine("4 - Visualizar Chamados");
            Console.WriteLine("S - Sair");
            Console.WriteLine("---------------------------------");
            Console.Write("> ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            // Operacoes CRUD - Create, Retrieve, Update, Delete

            if (opcaoMenu == "1")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Cadastro de Chamado");
                Console.WriteLine("---------------------------------");

                // Obtencao dos Dados
                Console.Write("Digite o título do chamado: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite a descricao do chamado: ");
                string descricao = Console.ReadLine();

                DateTime dataAbertura = DateTime.Now;

                // Apresentar os equipamentos cadastrados

                Console.WriteLine("---------------------------------");

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

                // Pedir para o usuario selecionar o ID equipamento desejado

                Console.Write("Digite o id do equipamento que deseja selecionar: ");
                int idEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());

                Equipamento equipamentoSelecionado = null;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    if (eq.id == idEquipamentoSelecionado)
                    {
                        equipamentoSelecionado = eq;
                        break;
                    }
                }

                Chamado novoChamado = new Chamado();
                novoChamado.id = contadosIdsChamados++;
                novoChamado.titulo = titulo;
                novoChamado.descricao = descricao;
                novoChamado.dataAbertura = dataAbertura;
                novoChamado.equipamento = equipamentoSelecionado;

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    if (chamadosSalvos[i] == null)
                    {
                        chamadosSalvos[i] = novoChamado;
                        break;
                    }
                }

                Console.WriteLine($"O chamado {novoChamado.titulo} foi cadastrado com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "2")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ediçao de Chamado");
                Console.WriteLine("---------------------------------");

                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -30} | {3, -17} | {4, -15}",
                    "Id", "Título", "Descriçao", "Data de Abertura", "Equipamento"
                );

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado ch = chamadosSalvos[i];

                    if (ch == null)
                        continue;

                    Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -30} | {3, -17} | {4, -15}",
                        ch.id, ch.titulo, ch.descricao, ch.dataAbertura, ch.equipamento.nome
                    );
                }
                Console.WriteLine("---------------------------------");
                Console.Write("Digite o id do chamado que deseja editar: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                Console.Write("digite o título do chamado: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite a descricao do chamado: ");
                string descricao = Console.ReadLine();

                Console.Write("Digite a nova data de abertura: ");
                DateTime dataAbertura = DateTime.Parse(Console.ReadLine());

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado chamadoSelecionado = chamadosSalvos[i];

                    if (chamadoSelecionado == null)
                        continue;
                    if (chamadoSelecionado.id == idSelecionado)
                    {
                        chamadoSelecionado.titulo = titulo;
                        chamadoSelecionado.descricao = descricao;
                        chamadoSelecionado.dataAbertura = dataAbertura;
                        break;
                    }
                }
                Console.WriteLine($"o Chamado {titulo} foi editado com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "3")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Exclusao de Chamados");
                Console.WriteLine("---------------------------------");

                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -30} | {3, -17} | {4, -15}",
                    "Id", "Título", "Descriçao", "Data de Abertura", "Equipamento"
                );

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado ch = chamadosSalvos[i];
                    if (ch == null)
                        continue;
                    Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -30} | {3, -17} | {4, -15}",
                   ch.id, ch.titulo, ch.descricao, ch.dataAbertura, ch.equipamento.nome
                    );
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite o id do chamado que deseja excluir: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado chamadoSelecionado = chamadosSalvos[i];

                    if (chamadoSelecionado == null)
                        continue;

                    if (chamadoSelecionado.id == idSelecionado)
                    {
                        chamadosSalvos[i] = null;
                        break;
                    }
                }
                Console.WriteLine($"O chamado foi excluído com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "4")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Visualizacao de Chamados");
                Console.WriteLine("---------------------------------");

                // Tabela
                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -30} | {3, -17} | {4, -15}",
                    "Id", "Título", "Descriçao", "Data de Abertura", "Equipamento"
                );

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    Chamado ch = chamadosSalvos[i];

                    if (ch == null)
                        continue;

                    Console.WriteLine(
                        "{0, -7} | {1, -15} | {2, -30} | {3, -17} | {4, -15}",
                        ch.id,
                        ch.titulo,
                        ch.descricao,
                        ch.dataAbertura.ToShortDateString(),
                        ch.equipamento.nome
                    );
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}