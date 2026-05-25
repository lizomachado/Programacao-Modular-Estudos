struct DadosPagamento
{
    public decimal Valor;
    public string Produto;
    public string Categoria;
    public string MetodoPagamento;

    public DadosPagamento(decimal valor, string produto, string categoria, string metodoPagamento)
    {
        Valor = valor;
        Produto = produto;
        Categoria = categoria;
        MetodoPagamento = metodoPagamento;
    }
}

static class Pagamento
{
    public static decimal Processar(DadosPagamento dados)
    {
        var desconto = 0m;

        if (dados.Categoria == "ELETRONICO")
            desconto += 0.10m;

        if (dados.Categoria == "ROUPA")
            desconto += 0.05m;

        if (dados.MetodoPagamento == "BOLETO")
            desconto += 0.01m;

        if (dados.MetodoPagamento == "PIX")
            desconto += 0.10m;

        decimal valorFinal = dados.Valor - (dados.Valor * desconto);

        return valorFinal;
    }
}