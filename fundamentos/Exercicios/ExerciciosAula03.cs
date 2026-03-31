using System;
 
namespace ExerciciosAula03
{
    /// <summary>
    /// 📋 EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS
    /// =======================================
    ///
    /// Exercício 1: Classificação de números
    /// Exercício 2: Par ou Ímpar (Operador Ternário)
    /// Exercício 3: Dias da semana (Switch/Case)
    /// Exercício 4: Sistema de Autenticação
    /// </summary>
    public class AlunoCondicionais
    {
        public void Executar()
        {
            Console.WriteLine("\n📋 1. EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS");
            Console.WriteLine("===========================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Classificação de números (if/else if/else)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário que digite um número
            // 2. Usar if/else if/else para classificar:
            //    - Se número > 0 → POSITIVO
            //    - Se número < 0 → NEGATIVO
            //    - Se número = 0 → ZERO
            // 3. Exibir o resultado
            //
            // 💡 Dica: Use Console.ReadLine() e Convert.ToInt32()
 
            Console.WriteLine("📝 Exercício 1: Classificação de números");
 
            // ESCREVA SEU CÓDIGO AQUI
            Console.WriteLine("Escolha um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero > 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Zero");
            }
 
            Console.WriteLine(); // Linha em branco
 
            // ===================================================
            // EXERCÍCIO 2: Par ou Ímpar (Operador Ternário)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário que digite um número
            // 2. Usar o operador ternário para verificar se é par ou ímpar
            //    Fórmula: número % 2 == 0 → "PAR", senão "ÍMPAR"
            // 3. Exibir o resultado
            //
            // 💡 Sintaxe do ternário: condição ? valor_se_true : valor_se_false
 
            Console.WriteLine("\n📝 Exercício 2: Par ou Ímpar (Ternário)");
            Console.Write("Escolha outro número: ");
 
            // ESCREVA SEU CÓDIGO AQUI
            int numero2 = Convert.ToInt32(Console.ReadLine());
            string parOuImpar = (numero2 % 2 == 0) ? "Par" : "Ímpar";
            Console.WriteLine($"Par ou Ímpar? {parOuImpar}");
 
            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 3: Dias da semana (Switch/Case)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário um número de 1 a 7
            // 2. Usar switch/case para exibir o dia correspondente:
            //    1 - Segunda-feira
            //    2 - Terça-feira
            //    3 - Quarta-feira
            //    4 - Quinta-feira
            //    5 - Sexta-feira
            //    6 - Sábado
            //    7 - Domingo
            // 3. Usar default para valores inválidos
            //
            // 💡 Cada case deve terminar com break
 
            Console.WriteLine("\n📝 Exercício 3: Dias da semana (Switch)");
            
            Console.Write("Escolha um número de 1 a 7: ");
 
            // ESCREVA SEU CÓDIGO AQUI
            int diaDaSemana = Convert.ToInt32(Console.ReadLine());
            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido! Digite um número entre 1 e 7.");
                    break;
            }
 
            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 4: Sistema de Autenticação
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Definir username e password corretos (admin/1234)
            // 2. Solicitar ao usuário que digite username e password
            // 3. Verificar se ambos estão corretos usando && (AND)
            // 4. Exibir "ACESSO PERMITIDO" ou "ACESSO NEGADO"
            //
            // 💡 Use == para comparar strings
 
            Console.WriteLine("\n📝 Exercício 4: Sistema de Autenticação");
            Console.Write("Username: ");
 
            // ESCREVA SEU CÓDIGO AQUI
            //definir username e password corretos
            string usernemeCorreto = "zédascouves";
            string passwordCorreta = "adoromaçâs";

            //solicitar username e password
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            //verificar se ambos estão corretos usando && (AND)
            if (username == usernemeCorreto && password == passwordCorreta)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }

 
            Console.WriteLine();
 
            // ===================================================
            // RESUMO FINAL
            // ===================================================
            Console.WriteLine("\n📌 Resumo das estruturas condicionais:");
            Console.WriteLine("if/else      → para decisões simples e complexas");
            Console.WriteLine("ternário ?:  → para atribuições simples");
            Console.WriteLine("switch/case  → para múltiplas opções de um valor");
            Console.WriteLine("&& (AND)     → todas condições devem ser verdadeiras");
        }
    }
}
 