namespace Fundamentos;

public class VariaveisETiposDeDados
{
        String sobreNome = "Costa";
        
    public void Executar()
    {
        Console.WriteLine("📦 VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine();

        int idade = 38;
        double altura = 1.72;
        float media = 1950;
        char letra = 'A';
        string nome = "Ricardo";
        string nomeComposto = nome + " Costa";//concatenação
        bool estudante = true;



        Console.WriteLine($"int -> idade: {idade} (numeros inteiros)");
        Console.WriteLine($"double -> altura: {altura} (numeros Decimais)");
        Console.WriteLine($"char -> letra: {letra} (um unico caracter)");
        Console.WriteLine($"string -> nome: {nomeComposto} (texto)");
        Console.WriteLine($"bool -> estudante: {estudante} (booleano ou seja Verdadeiro ou Falso)");
        Console.WriteLine($"variavel global -> sobreNome: {this.sobreNome} (Variavel Global)");

    }



}// fim class