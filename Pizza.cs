class Pizza
{
    //*atributos

    public int Id;
    public double Preco;
    public string Sabor;
    public string Tamanho;

    //#construtores
    public Pizza(int id, string sabor, string tamanho, double preco)
    {
        this.Sabor = sabor;
        this.Tamanho = tamanho;
        this.Preco = preco;
        this.Id = id;
    }

    //@metodos
    public static void setPizzaCardapio(Pizza novaPizza)
    {
        Program.cardapio.Add(novaPizza);
    }

}