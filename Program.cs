using Estoque.Database;
using Estoque.Models;
using Microsoft.IdentityModel.Tokens;

using DataContext db = new();

Armazenamento estoque = new();


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
    Console.WriteLine("Digite 1 para registrar um produto");
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

void RegistrarProduto()
{
    ExibirTituloDaOpcao("Registrar Produto");

    Console.Write("Digite o nome do produto que deseja adicionar: ");
    string nomeProduto = Console.ReadLine()!;

    if (nomeProduto.IsNullOrEmpty()) 
    {
        Console.WriteLine("O nome produto deve ser preenchido");
        Thread.Sleep(2900);
        Console.Clear();
        RegistrarProduto();
    }

    Console.Write("\nDigite o preço do produto: ");
    double precoProduto = double.Parse(Console.ReadLine()!);

    if(precoProduto < 0)
    {
        Console.WriteLine("O preço do produto precisa ser informado");
        Thread.Sleep(2900);
        Console.Clear();
        RegistrarProduto();
    }

    Produto p = new()
    {
        Nome = nomeProduto,
        Preco = precoProduto
    };

    db.Produto.Add(p);
    db.SaveChanges();

    Console.WriteLine($"O produto {p.Nome} com o valor {precoProduto}R$ foi adicionado com sucesso");
    Thread.Sleep(3500);
    ExibirOpcoesDoProduto();
}

void RemoverProduto()
{
    throw new NotImplementedException();
}

void AtualizarProduto()
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



ExibirOpcoesDoMenu();