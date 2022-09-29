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

    public static Pizza getPizzaCardapio(int id)
    {
        var cardapio = Program.cardapio;
        var pizza_encontrada = new Pizza();
        int total = cardapio.Count();

        for (int i = 0; i < total; i++)
        {
            if (cardapio[i].Id == id)
            {
                pizza_encontrada = new Pizza(cardapio[i].Sabor, cardapio[i].Tamanho, cardapio[i].Preco);
                break;
            }
            else
            {
                Console.WriteLine($"Pizza nao encontrada...do else");
                Console.ReadLine();
            }

        }
        return pizza_encontrada;
    }
};