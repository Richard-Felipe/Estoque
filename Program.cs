using Estoque.Database;

using DataContext db = new();

void LogoProduto()
{
    Console.WriteLine(@"
██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗████████╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║╚══██╔══╝██╔══██╗
██████╔╝██████╔╝██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║
██╔═══╝░██╔══██╗██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║
██║░░░░░██║░░██║╚█████╔╝██████╔╝╚██████╔╝░░░██║░░░╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═════╝░░╚═════╝░░░░╚═╝░░░░╚════╝░");
    
    Console.WriteLine("\nBem vindo ao menu de produto :D\n");
}

void LogoEstoque()
{
    Console.WriteLine(@"
███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝");

    Console.WriteLine("\nBem vindo ao menu de estoque :D\n");
}

void Logo()
{
    Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
████╗░████║██╔════╝████╗░██║██║░░░██║
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");

    Console.WriteLine("\nBem vindo ao aplicativo :D\n");
}

void ExibirTituloDaOpcao(string titulo)
{
    Console.Clear();
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    Logo();
    Console.WriteLine("\nDigite 1 para acessar a tela de Estoque");
    Console.WriteLine("Digite 2 acessar a tela de Produto");
    Console.WriteLine("Digite 0 para sair da aplicação");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            ExibirOpcoesDoEstoque();
            break;
        case 2:
            ExibirOpcoesDoProduto();
            break;
        case 0:
            Console.WriteLine("Tchau tchau :D");
            break;
        default:
            Console.WriteLine("Opção inválida, digite alguma das opções acima");
            Thread.Sleep(2900);
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
    }
}

void ExibirOpcoesDoProduto()
{
    Console.Clear();
    LogoProduto();
    Console.WriteLine("Digite 6 para voltar ao menu principal");
    Console.WriteLine("Digite 0 para sair da aplicação");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarProduto();
            break;
        case 2:
            ListarTodosProduto();
            break;
        case 3:
            AdicionarProduto();
            break;
        case 4:
            RemoverProduto();
            break;
        case 5:
            AtualizarProduto();
            break;
        case 6:
            ExibirOpcoesDoMenu();
            break;
        case 0:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida, digite alguma das opções acima");
            Thread.Sleep(2900);
            Console.Clear();
            ExibirOpcoesDoProduto();
            break;
    }
}

void ExibirOpcoesDoEstoque()
{
    Console.Clear();
    LogoEstoque();
    Console.WriteLine("Digite 6 para voltar ao menu principal");
    Console.WriteLine("Digite 0 para sair da aplicação");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarProduto();
            break;
        case 2:
            ListarTodosProduto();
            break;
        case 3:
            AdicionarProduto();
            break;
        case 4:
            RemoverProduto();
            break;
        case 5:
            AtualizarProduto();
            break;
        case 6:
            ExibirOpcoesDoMenu();
            break;
        case 0:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida, digite alguma das opções acima");
            Thread.Sleep(2900);
            Console.Clear();
            ExibirOpcoesDoEstoque();
            break;
    }
}

void AtualizarProduto()
{
    throw new NotImplementedException();
}

void RemoverProduto()
{
    throw new NotImplementedException();
}

void AdicionarProduto()
{
    throw new NotImplementedException();
}

void ListarTodosProduto()
{
    throw new NotImplementedException();
}

void RegistrarProduto()
{
    throw new NotImplementedException();
}

ExibirOpcoesDoMenu();