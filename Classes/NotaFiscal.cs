class NotaFiscal
{
    //**atributos
    public string NomeCliente;
    private string ID_Nota;
    public List<Pizza> PizzaEscolhida;
    public List<Adicionais> ItensAdiconais;

    public double getTotalDaNota()
    {
        double total = 0;
        if (PizzaEscolhida.Count > 0)
        {
            for (int i = 0; i < PizzaEscolhida.Count; i++)
            {
                total += PizzaEscolhida[i].Preco;
            }
        }

        if (ItensAdiconais.Count > 0)
        {
            for (int i = 0; i < ItensAdiconais.Count; i++)
            {
                total += ItensAdiconais[i].Preco;

            }
        }

        return total;

    }

    public void getItensDaNota()
    {
        Console.WriteLine($"Pizza(s) Selecionada(s):");

        PizzaEscolhida.ForEach(item => { Console.WriteLine($"Sabor: {item.Sabor} __ Tamanho: {item.Tamanho} __ Preco {item.Preco}"); });

        Console.WriteLine($"________________________");

        Console.WriteLine($"ItensAdiconais");

        ItensAdiconais.ForEach(item => { Console.WriteLine($"Adicional: {item.Item} __ Preco{item.Preco}"); });

        Console.WriteLine($"________________________");

        Console.WriteLine($"Total da Nota");
        getTotalDaNota().ToString("C");

    }
}