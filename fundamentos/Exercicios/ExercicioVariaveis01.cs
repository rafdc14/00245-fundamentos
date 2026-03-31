namespace Fundamentos;

public class Exercicio01
{
    public void Executar()//colocar no separador da aula01 como new
    {
        Console.WriteLine("\n📋 1. EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("=============================================\n");
        
        Console.WriteLine("===================================================");
        Console.WriteLine("📝 Exercício 1: Declaração de variáveis básicas");
        Console.WriteLine("===================================================");
        Console.WriteLine();

        int exercicio = 1;
        string nome = "Ricardo";
        string nomeComposto = nome + " Costa";
        int idade = 38;
        bool estudante = true;


        Console.WriteLine($"Exercício: {exercicio}");
        Console.WriteLine();
        Console.WriteLine($"Nome: {nomeComposto}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Estudante: {estudante}");


    }


}