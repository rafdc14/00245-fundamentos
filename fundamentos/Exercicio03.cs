namespace Fundamentos;

public class Exercicio03
{
    public void Executar()
    {
        Console.WriteLine("===================================================");
        Console.WriteLine("EXERCÍCIO 3: Flexibilidade do tipo object");
        Console.WriteLine("===================================================");
        Console.WriteLine();
        
        object valor;

        valor = "Bom dia";
        Console.WriteLine("Frase: " + valor);
        valor = "Como estão?";
        Console.WriteLine("Frase: " + valor);        
        valor = 11.3;
        Console.WriteLine("Valor: " + valor);
        valor = false;
        Console.WriteLine("Lógico: " + valor);


    }




}
