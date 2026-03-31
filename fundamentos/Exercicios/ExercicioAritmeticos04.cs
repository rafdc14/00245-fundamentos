namespace Fundamentos;

public class ExerciciosAritmeticos04()
{
    public void Executar()
    {
         // ===================================================
    // EXERCÍCIO 4: Multiplicação e divisão
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Usar os mesmos números
    // 2. Fazer uma multiplicação (*)
    // 3. Fazer uma divisão (/)
    // 4. Mostrar os resultados
    //
    // 💡 Regra:
    // * → multiplicação
    // / → divisão
    // (double) força resultado decimal
 
    Console.WriteLine("📝 Exercício 4: Multiplicação e divisão");
    Console.WriteLine("---------------------------------------");
    int numero1 = 11;
    int numero2 = 5;
    int multiplicacao = numero1 * numero2;
    double divisao = numero1 / numero2;
    Console.WriteLine();
    Console.WriteLine($"11 x 5 = {multiplicacao}");
    Console.WriteLine($"11 / 5 = {divisao}");
    Console.WriteLine($"Resto = {numero1 % numero2}");

    }


}