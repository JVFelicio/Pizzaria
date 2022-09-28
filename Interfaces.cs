using System.Globalization;
class Interfaces
{
    public static void showCadastrarPizza()
    {
        bool executing = true;
        while (executing)
        {

            Console.Clear();
            Console.WriteLine($"Cadastrar Pizza Selecionado\n");
            Console.WriteLine("Sabor da pizza");
            string sabor = Console.ReadLine();

            Console.WriteLine($"\nTamanho da pizza (G, M ou P)");
            string tamanho = Console.ReadLine();

            Console.WriteLine($"\nPreço da pizza");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int id = Program.cardapio.IndexOf(Program.cardapio.Last()) + 1;

            Pizza pizzaNova = new Pizza(id, sabor, tamanho, preco);

            Pizza.setPizzaCardapio(pizzaNova);

            Console.WriteLine($"Deseja cadastrar mais uma pizza\nSim: 1\nNão:0");
            int resp = int.Parse(Console.ReadLine());

            if (resp != 1)
            {
                executing = false;
            }
        }
        Console.WriteLine($"Pizzas Cadastradas com sucesso, pressione enter para continuar...");
        Console.ReadLine();

    }

    public static void showCardapio()
    {
        Program.cardapio.ForEach(pizza => Console.WriteLine($"Sabor:{pizza.Sabor} Tamanho:{pizza.Tamanho} Preço:{pizza.Preco.ToString("C")} Id:{pizza.Id}"));
    }

    public static void showNovoPedido()
    {
        Console.WriteLine($"Novo pedido iniciado");
        Console.Write($"\nNome do Cliente:");
        string nomeCliente = Console.ReadLine();




    }

    public static void showExtraItens()
    {
        Console.WriteLine($"Lista de Itens Adicionais");

    }
}