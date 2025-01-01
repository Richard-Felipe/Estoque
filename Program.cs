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
    Console.WriteLine("Digite 1 - para Listar todos os produtos");
    Console.WriteLine("Digite 2 - para registrar um produto");
    Console.WriteLine("Digite 3 - para remover um produto");
    Console.WriteLine("Digite 4 - para atualizar um produto");
    Console.WriteLine("Digite 5 - para voltar ao menu principal");
    Console.WriteLine("Digite 0 - para sair da aplicação");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            ListarTodosProduto();
            break;
        case 2:
            RegistrarProduto();
            break;
        case 3:
            RemoverProduto();
            break;
        case 4:
            AtualizarProduto();
            break;
        case 5:
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
        //case 1:
        //    RegistrarProduto();
        //    break;
        //case 2:
        //    RemoverProduto();
        //    break;
        //case 3:
        //    AdicionarProduto();
        //    break;
        //case 4:
        //    ListarTodosProduto();
        //    break;
        //case 5:
        //    AtualizarProduto();
        //    break;
        //case 6:
        //    ExibirOpcoesDoMenu();
        //    break;
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
    string nomeProduto = Console.ReadLine()!.ToLower();

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
        Console.WriteLine("O preço do produto precisa ser informado e não pode ser negativo");
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

    Console.WriteLine($"\nO produto {p.Nome} com o valor {p.Preco}R$ foi adicionado com sucesso");
    Thread.Sleep(3500);
    ExibirOpcoesDoProduto();
}

void RemoverProduto()
{
    ExibirTituloDaOpcao("Remover Produto");

    Console.Write("Digite o nome do produto que deseja remover: ");
    string nomeProduto = Console.ReadLine()!.ToLower();

    var produtodb = db.Produto.FirstOrDefault(n => n.Nome == nomeProduto);

    if(produtodb is null)
    {
        Console.WriteLine("O produto não esta cadastrado no sistema");
        Thread.Sleep(3500);
        Console.Clear();
        RemoverProduto();
    }
    
    db.Produto.Remove(produtodb);
    db.SaveChanges();

    Console.WriteLine($"\nO produto {produtodb.Nome} foi removido com sucesso");
    Thread.Sleep(3500);
    ExibirOpcoesDoProduto();
}

void AtualizarProduto()
{
    ExibirTituloDaOpcao("Atualizar Produto");

    Console.Write("Digite o nome do produto que deseja Alterar: ");
    string nomeProduto = Console.ReadLine()!.ToLower();

    var produtodb = db.Produto.FirstOrDefault(n => n.Nome == nomeProduto);

    if (produtodb is null)
    {
        Console.WriteLine("O produto não esta cadastrado no sistema");
        Thread.Sleep(3500);
        Console.Clear();
        AtualizarProduto();
    }

    Console.Write("\nDeseja alterar o nome do produto ? Digite 's' para sim o 'n' para não: ");
    string opcaoEscolhida = Console.ReadLine()!.ToLower();

    if(opcaoEscolhida == "s" || opcaoEscolhida == "sim")
    {
        Console.Write("Digite o novo nome do produto: ");
        string novoNome = Console.ReadLine()!.ToLower();

        produtodb.Nome = novoNome;
    }

    Console.Write($"\nDigite o novo preço do produto {produtodb.Nome}: ");
    double novoPreco = double.Parse(Console.ReadLine()!);

    if (novoPreco < 0)
    {
        Console.WriteLine("O preço do produto precisa ser informado e não pode ser negativo");
        Thread.Sleep(2900);
        Console.Clear();
        AtualizarProduto();
    }

    produtodb.Preco = novoPreco;

    db.Produto.Update(produtodb);
    db.SaveChanges();

    Console.WriteLine($"\nO produto {produtodb.Nome} com o valor {produtodb.Preco}R$ foi alterado com sucesso");
    Thread.Sleep(3500);
    ExibirOpcoesDoProduto();
}

void ListarTodosProduto()
{
    ExibirTituloDaOpcao("Lista de todos os produtos cadastrados no sistema");

    var produtos = db.Produto.ToList();

    foreach (var produto in produtos)
    {
        Console.WriteLine($"Produto: {produto.Nome} - Valor: {produto.Preco}R$");
    }

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    ExibirOpcoesDoProduto();
}

ExibirOpcoesDoMenu();