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

            Services.setPizzaCardapio(pizzaNova);

            Console.WriteLine($"Deseja cadastrar mais uma pizza\nSim: 1\nNão:0");
            int resp = int.Parse(Console.ReadLine());

            executing = resp != 1 ? false : true;
        }

        Console.WriteLine($"Pizzas Cadastradas com sucesso, pressione enter para continuar...");
        Console.ReadLine();
    }

    public static void showCardapio()
    {
        Console.WriteLine($"\n----------CARDÁPIO----------");
        Program.cardapio.ForEach(pizza =>
        {

            Console.WriteLine($"Sabor:{pizza.Sabor} Tamanho:{pizza.Tamanho} Preço:{pizza.Preco.ToString("C")} Id:{pizza.Id}");
            Console.WriteLine($"_____________________________");
        });
    }

    public static void showNovoPedido()
    {
        var pizzas_selecionadas = new List<Pizza>();

        Console.WriteLine($"Novo pedido iniciado");
        Console.Write($"\nNome do Cliente:");
        string nomeCliente = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"\nVamos escolher um sabor, selecione a Pizza pelo ID:");
        bool executing = true;
        while (executing)
        {
            var pizzaEscolhida = new Pizza(); //
            Interfaces.showCardapio();
            Console.WriteLine($"Qual o Id da pizza ?");
            int id_pizza = int.Parse(Console.ReadLine());
            pizzaEscolhida = Services.getPizzaCardapio(id_pizza);
            pizzas_selecionadas.Add(pizzaEscolhida);

            Console.WriteLine($"Deseja adicionar mais uma pizza ? Sim:1 Nao: 2");
            int resp = int.Parse(Console.ReadLine());
            executing = resp != 1 ? false : true;

        }
        Console.WriteLine($"__________Pizzas selecionadas_________");
        pizzas_selecionadas.ForEach(pizza => Console.WriteLine(pizza.Sabor + " " + pizza.Tamanho + " " + pizza.Preco));

    }

    public static void showExtraItens()
    {
        Console.WriteLine($"Lista de Itens Adicionais");

    }
}