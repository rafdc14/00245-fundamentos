namespace Fundamentos;
public class EstruturaControleBasicas
{
    public void ExecutarIfElse()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("Estruturas de controlo básicas\n");
        Console.WriteLine("======================================");
        Console.WriteLine();

        // 1 ESTRUTURA IF-ELSE
        int nota = 14;
        Console.WriteLine($"Nota do aluno: {nota}");

        if (nota >= 14)
        {
            Console.WriteLine("Situação: APROVADO (IF)");
        }
        else
        {
            Console.WriteLine("Situação: REPROVADO (ELSE)");
        }






    }// fim executar


    //Estrutura Switch Case
    //compara uma variável com multiplios valores   
    //usar em vez de if-else quando tiver mais de 3 condições para comparar
    public void ExecutarSwitchCase()
    {
        int diaDaSemana = 3;
        Console.WriteLine($"Numero do dia da semana: {diaDaSemana}");

        switch (diaDaSemana)
        {
            case 1:
                Console.WriteLine("Dia: Segunda-feira");
                break;
            case 2:
                Console.WriteLine("Dia: Terça-feira");
                break;
            case 3:
                Console.WriteLine("Dia: Quarta-feira"); 
                break;
            case 4:
                Console.WriteLine("Dia: Quinta-feira");
                break;
            case 5:
                Console.WriteLine("Dia: Sexta-feira");
                break;
            case 6:
                Console.WriteLine("Dia: Sábado");
                break;

            default:
                Console.WriteLine("Domingo");
                break;
        }



    }

    //TERNARIO
    //TERNARIO é um operador que tem 3 operandos, é uma forma mais simples de escrever um if-else
    public void ExecutarTernario()
    {
        int idade = 17;
        string status = (idade >= 18) ?"Maior de 18" : "Menor de 18";
        Console.WriteLine($"Idade: {idade} -> {status}");
    }

}//fim da classe