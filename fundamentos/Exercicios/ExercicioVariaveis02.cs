namespace Fundamentos;

public class Exercicio02
{
    public void Executar()
    {
        Console.WriteLine("===================================================");
        Console.WriteLine("EXERCÍCIO 2: Reatribuição de valores");
        Console.WriteLine("===================================================");
        Console.WriteLine();
        
        int exercicio = 2;
        int nivel = 1;
        string descricao = "aprendiz";
        bool temCompetencia = false;

        Console.WriteLine($"Exercicio: " + exercicio);
        Console.WriteLine();
        Console.WriteLine($"Nível: {nivel}");
        Console.WriteLine($"{descricao}");
        Console.WriteLine($"Possui competências?:" + temCompetencia);
        Console.WriteLine();

        nivel = 5;
        descricao = "intermédio";
        temCompetencia = true;
        Console.WriteLine($"Nível: {nivel}");
        Console.WriteLine($"{descricao}");
        Console.WriteLine($"Possui competências?:" + temCompetencia);



        
    }



}