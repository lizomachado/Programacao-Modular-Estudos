struct Tempo
{
    public int horas;
    public int minutos;
    public int segundos;

    public Tempo(int h, int m, int s)
    {
        horas = h;
        minutos = m;
        segundos = s;
    }

    public int ConverterSegundos()
    {
        return horas * 3600 + minutos * 60 + segundos;
    }

    public static Tempo ConverterTempo(int totalSegundos)
    {
        int h = totalSegundos / 3600;

        totalSegundos = totalSegundos % 3600;

        int m = totalSegundos / 60;

        int s = totalSegundos % 60;

        Tempo tempo = new Tempo(h, m, s);

        return tempo;
    }

    public string Mostrar()
    {
        return horas + ":" + minutos + ":" + segundos;
    }
}