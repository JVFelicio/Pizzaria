class Program
{
    public static List<Pizza> cardapio = new List<Pizza>();
    public static void Main(string[] args)
    {
        Pizza pizzaTeste = new Pizza(0, "Queijo", "G", 20.00);
        cardapio.Add(pizzaTeste);
        Console.Clear();

        bool executing = true;

        while (executing)
        {
            Console.WriteLine($"|--------- Pizzaria Florência ---------|\n|                                      |\n|--------------------------------------|");
            Console.WriteLine($"Para cadastrar uma nova pizza: 1\nPara iniciar um novo pedido: 2\nPara encerrar: 0");
            int option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Interfaces.showCadastrarPizza();
                    break;

                case 2:
                    Interfaces.showNovoPedido();
                    break;

            }

            Console.WriteLine($"Voltar ao menu:1 Encerrar:0");
            int resp = int.Parse(Console.ReadLine());
            executing = resp != 1 ? false : true;

        }



    }
};