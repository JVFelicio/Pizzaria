class Services
{
    public static string setIdAleatório(int tamanho = 6)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var result = new string(
            Enumerable.Repeat(chars, tamanho)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
        return result;
    }

    public static void setPizzaCardapio(Pizza novaPizza)
    {
        Program.cardapio.Add(novaPizza);
    }

    public static List<Pizza> getPizzaCardapio(int id)
    {
        var cardapio = Program.cardapio;
        var pizza_encontrada = new Pizza();
        var selecionada = new List<Pizza>();

        foreach (var item in cardapio)
        {
            if (item.Id == id)
            {
                Console.WriteLine($"cardapio dentro do getcardapio if certo");
                Console.WriteLine(item.Sabor + " " + item.Tamanho + " " + item.Preco);
                pizza_encontrada = new Pizza(item.Sabor, item.Tamanho, item.Preco);
                selecionada.Add(pizza_encontrada);
                Console.ReadLine();

                break;
            }
            else
            {
                Console.WriteLine($"Pizza não encontrada...");
                Console.ReadLine();
                break;
            }

        }
        return selecionada;
    }
};