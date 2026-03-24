namespace Fundamentos;

public class Aula01
{
      
    public void ExecutarAula()
    {
        //inicio
        this.ExibirCabecalho();
        VariaveisETiposDeDados variaveisETiposDeDados = new VariaveisETiposDeDados();
        variaveisETiposDeDados.Executar();
        Console.WriteLine(); //criar espaço no programa para as linhas não ficarem juntas
        
        //operadores aritmeticos
        OperadoresAritmeticos operadoresAritmeticos = new OperadoresAritmeticos();
        operadoresAritmeticos.Executar();
        Console.WriteLine();
        
        //operadores de comparação
        OperadoresDeComparacao operadoresDeComparacao = new OperadoresDeComparacao();
        operadoresDeComparacao.Executar();
        Console.WriteLine();

        //operadores lógicos
        OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
        operadoresLogicos.Executar();
        Console.WriteLine();

        //Exercicio 01
        

        

        //fim
        this.ResumoAula();

        //this é tudo o que está dentro da public class
    }
      
      private void ExibirCabecalho()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   AULA 01 - FUNDAMENTOS DE ALGORITMIA");
        Console.WriteLine("======================================");
        Console.WriteLine();
    }
    //void executa apenas a função sem devolver nada
 
    private void ResumoAula()
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("   FIM DA AULA - RESUMO");
        Console.WriteLine("======================================");
        Console.WriteLine("✓ O que é algoritmia");
        Console.WriteLine("✓ Variáveis e tipos de dados");
        Console.WriteLine("✓ Operadores aritméticos, comparação e lógicos");
        Console.WriteLine("✓ Estruturas de controle básicas");
    }
 





}// fim da Aula01