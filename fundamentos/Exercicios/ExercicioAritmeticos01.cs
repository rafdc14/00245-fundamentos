namespace Fundamentos;

public class ExercicioAritmeticos01
{
    public void Executar()
    {
        Console.WriteLine("\n🧮 3. EXERCÍCIOS DE OPERADORES ARITMÉTICOS");
        Console.WriteLine("=========================================\n");

        // ===================================================
    // EXERCÍCIO 1: Soma e subtração
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis numéricas
    // 2. Fazer uma soma usando +
    // 3. Fazer uma subtração usando -
    // 4. Mostrar os resultados no console
    //
    // 💡 Regra:
    // + → soma valores
    // - → subtrai valores
 
        Console.WriteLine("📝 Exercício 1: Soma e subtração");
        Console.WriteLine("------------------------------");
        string somar = "Soma";
        string subtrair = "Subtração";
        int numero1 = 3;
        int numero2 = 6;
        int soma = numero2 + numero1;
        int subtracao = numero2 - numero1;
        Console.WriteLine();
        Console.WriteLine($"{somar}");
        Console.WriteLine($"Quanto é 6 + 3?");
        Console.WriteLine($"Resposta: {numero2} + {numero1} = {soma}");
        Console.WriteLine();
        Console.WriteLine($"{subtrair}");
        Console.WriteLine($"Quanto é 6 - 3?");
        Console.WriteLine($"Resposta: {numero2} - {numero1} = {subtracao}");
        Console.WriteLine();

    }



}