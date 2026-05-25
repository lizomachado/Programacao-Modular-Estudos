Tempo tempo1 = new Tempo(10, 12, 34);

Tempo tempo2 = new Tempo(3, 45, 4);

Tempo soma = Temporal.Somar(tempo1, tempo2);

Console.WriteLine("Soma: " + soma.Mostrar());

Tempo subtracao = Temporal.Subtrair(tempo1, tempo2);

Console.WriteLine("Subtração: " + subtracao.Mostrar());

Tempo multiplicacao = Temporal.Multiplicar(tempo1, 2);

Console.WriteLine("Multiplicação: " + multiplicacao.Mostrar());

Tempo divisao = Temporal.Dividir(tempo1, 2);

Console.WriteLine("Divisão: " + divisao.Mostrar());

DadosPagamento pagamento = new DadosPagamento(
    100m,
    "Smartphone",
    "ELETRONICO",
    "PIX"
);

decimal valorFinal = Pagamento.Processar(pagamento);

Console.WriteLine("Valor final após desconto: R$ " + valorFinal);