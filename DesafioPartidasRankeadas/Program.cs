using System;

class Jogador
{
    public int CalcularSaldo(int vitorias, int derrotas)
    {
        return vitorias - derrotas;
    }

    public string DeterminarNivel(int saldoVitorias)
    {
        if (saldoVitorias < 10)
            return "Ferro";
        else if (saldoVitorias >= 11 && saldoVitorias <= 20)
            return "Bronze";
        else if (saldoVitorias >= 21 && saldoVitorias <= 50)
            return "Prata";
        else if (saldoVitorias >= 51 && saldoVitorias <= 80)
            return "Ouro";
        else if (saldoVitorias >= 81 && saldoVitorias <= 90)
            return "Diamante";
        else if (saldoVitorias >= 91 && saldoVitorias <= 100)
            return "Lendário";
        else
            return "Imortal";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Partidas Ranqueadas");

        Console.Write("Informe o número de vitórias: ");
        int vitorias = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de derrotas: ");
        int derrotas = int.Parse(Console.ReadLine());

        Jogador jogador = new Jogador();
        int saldoVitorias = jogador.CalcularSaldo(vitorias, derrotas);
        string nivel = jogador.DeterminarNivel(saldoVitorias);

        Console.WriteLine($"O Herói tem um saldo de {saldoVitorias} e está no nível de {nivel}");
    }
}