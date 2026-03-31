using ExerciciosAula03;
using FundamentosAlgoritmia;

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

        //Estruturas de controle básicas
        EstruturaControleBasicas estruturaControleBasicas = new EstruturaControleBasicas();
        estruturaControleBasicas.ExecutarIfElse();
        estruturaControleBasicas.ExecutarSwitchCase();
        estruturaControleBasicas.ExecutarTernario();
        Console.WriteLine();

        // ExerciciosEVariaveisETiposDeDados exerciciosEVariaveisETiposDeDados = new ExerciciosEVariaveisETiposDeDados();
        // exerciciosEVariaveisETiposDeDados.Executar();
        // Console.WriteLine();

        //Exercicio 01
        //Exercicio01 exercicio01 = new Exercicio01();
        //exercicio01.Executar();
        //Console.WriteLine();

        //Exercicio 02
        //Exercicio02 exercicio02 = new Exercicio02();
        //exercicio02.Executar();
        //Console.WriteLine();

        //Exercicio 03
        //Exercicio03 exercicio03 = new Exercicio03();
        //exercicio03.Executar();
        //Console.WriteLine();

        // ExerciciosOperadoresAritmeticos exerciciosOperadoresAritmeticos = new ExerciciosOperadoresAritmeticos();
        // exerciciosOperadoresAritmeticos.Executar();
        // Console.WriteLine();

        // ExercicioAritmeticos01 exercicioAritmeticos01 = new ExercicioAritmeticos01();
        // exercicioAritmeticos01.Executar();
        // Console.WriteLine();

        // ExercicioAritmeticos02 exercicioAritmeticos02 = new ExercicioAritmeticos02();
        // exercicioAritmeticos02.Executar();
        // Console.WriteLine();

        // ExerciciosAritmeticos03 exerciciosAritmeticos03 = new ExerciciosAritmeticos03();
        // exerciciosAritmeticos03.Executar();
        // Console.WriteLine();

        // ExerciciosAritmeticos04 exerciciosAritmeticos04 = new ExerciciosAritmeticos04();
        // exerciciosAritmeticos04.Executar();
        // Console.WriteLine();

        // ExercicioAritmetico05 exercicioAritmeticos05 = new ExercicioAritmetico05();
        // exercicioAritmeticos05.Executar();
        // Console.WriteLine();


        ExerciciosOperadoresLogicos exerciciosOperadoresLogicos = new ExerciciosOperadoresLogicos();
        exerciciosOperadoresLogicos.Executar();
        Console.WriteLine();

        //Exercicios Aula 03
        // AlunoCondicionais alunoCondicionais = new AlunoCondicionais();
        // alunoCondicionais.Executar();
        // Console.WriteLine();


        
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