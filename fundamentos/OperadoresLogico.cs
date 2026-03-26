
namespace Fundamentos;

public class OperadoresLogicos
{
    public void Executar()
    {
        Console.WriteLine("OPERADORES LOGICOS");
        
        bool temIdade = true;
        bool temCarta = false;

        Console.WriteLine($"Tem idade ? {temIdade}");
        Console.WriteLine($"Tem Carta ? {temCarta}");
        Console.WriteLine();
        Console.WriteLine($"Pode conduzir? (temIdade e Carta) -> {temIdade && temCarta} (AND)");
        Console.WriteLine($"Pode tentar tirar? (temIdade OU Carta) -> {temIdade || temCarta} (OR)");
        Console.WriteLine($"Não tem idade? (!temIdade) -> {!temIdade} (NOT)");
        
    }





}//fim da classe