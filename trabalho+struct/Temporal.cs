static class Temporal
{
    public static Tempo Somar(Tempo t1, Tempo t2)
    {
        int total;

        total = t1.ConverterSegundos() + t2.ConverterSegundos();

        Tempo resultado = Tempo.ConverterTempo(total);

        return resultado;
    }

    public static Tempo Subtrair(Tempo t1, Tempo t2)
    {
        int total;

        total = t1.ConverterSegundos() - t2.ConverterSegundos();

        Tempo resultado = Tempo.ConverterTempo(total);

        return resultado;
    }

    public static Tempo Multiplicar(Tempo t1, int numero)
    {
        int total;

        total = t1.ConverterSegundos() * numero;

        Tempo resultado = Tempo.ConverterTempo(total);

        return resultado;
    }

    public static Tempo Dividir(Tempo t1, int numero)
    {
        int total;

        total = t1.ConverterSegundos() / numero;

        Tempo resultado = Tempo.ConverterTempo(total);

        return resultado;
    }
}