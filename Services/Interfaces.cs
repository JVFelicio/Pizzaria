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
    public static void showAdicionais()
    {
        Console.WriteLine($"\n----------ADICIONAIS----------");
        Program.extras.ForEach(extra =>
        {

            Console.WriteLine($"Item:{extra.Item} Preço:{extra.Preco.ToString("C")} Id:{extra.ID}");
            Console.WriteLine($"_____________________________");
        });
    }

    public static void showNovoPedido()
    {
        var pizzas_selecionadas = new List<Pizza>();
        var adicionais_selecionadas = new List<Adicionais>();

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

        Console.Clear();
        Console.WriteLine($"Deseja adicionar Extras ? Sim:1 Nao:0");
        int opt = int.Parse(Console.ReadLine());
        executing = opt != 1 ? false : true;
        while (executing)
        {
            var itemEscolhido = new Adicionais(); //
            Interfaces.showAdicionais();
            Console.WriteLine($"Qual o Id do item ?");
            int id_item = int.Parse(Console.ReadLine());
            itemEscolhido = Services.getItemAdicional(id_item);
            adicionais_selecionadas.Add(itemEscolhido);

            Console.WriteLine($"Deseja adicionar mais um item ? Sim:1 Nao: 2");
            int resp = int.Parse(Console.ReadLine());
            executing = resp != 1 ? false : true;

        }

        string id_comanda = Services.setIdAleatório();

        Console.WriteLine($"__________Pizzas selecionadas_________");
        pizzas_selecionadas.ForEach(pizza => Console.WriteLine(pizza.Sabor + " " + pizza.Tamanho + " " + pizza.Preco));

    }

}