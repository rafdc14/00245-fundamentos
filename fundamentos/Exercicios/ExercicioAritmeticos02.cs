namespace Fundamentos;

public class ExercicioAritmeticos02
{
    public void Executar()
    {
        
    // ===================================================
    // EXERCÍCIO 2: Cálculo de área
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis (largura e altura)
    // 2. Multiplicar os valores
    // 3. Mostrar o resultado
    //
    // 💡 Regra:
    // Área do retângulo = largura × altura
    // Usamos double para valores com casas decimais
 
        Console.WriteLine("📝 Exercício 2: Cálculo de área do retângulo");
        Console.WriteLine("------------------------------");
        int comprimento = 15;
        int largura = 7;
        int areaDoRetangulo = comprimento * largura;
        Console.WriteLine();
        Console.WriteLine($"O retângulo tem {comprimento} de comprimento e {largura} de largura.");
        Console.WriteLine();
        Console.WriteLine($"Qual a área do retângulo?");
        Console.WriteLine();
        Console.WriteLine($"Resposta: {comprimento} * {largura} = {areaDoRetangulo}"); 

    }



}