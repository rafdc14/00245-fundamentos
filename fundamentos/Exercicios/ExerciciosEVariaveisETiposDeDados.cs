namespace Fundamentos;

    /// <summary>
    /// 📋 SUMÁRIO DOS EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS
    /// =====================================================
    ///
    /// Exercício 1: Declaração de variáveis básicas
    /// - Aprender a declarar variáveis com tipos diferentes
    /// - Usar string (texto), int (números inteiros) e bool (verdadeiro/falso)
    /// - Utilizar o método GetType() para descobrir o tipo da variável
    ///
    /// Exercício 2: Reatribuição de valores
    /// - Entender que variáveis podem mudar de valor
    /// - Declarar uma variável e depois atribuir um novo valor
    ///
    /// Exercício 3: Flexibilidade do tipo object
    /// - Conhecer o tipo object que pode guardar qualquer tipo de dado
    /// - Ver como o tipo pode mudar durante a execução
    ///
    /// Demonstração adicional:
    /// - Conhecer outros tipos: double (decimais), char (um caractere), decimal (precisão monetária)
    /// </summary>
    public class ExerciciosEVariaveisETiposDeDados
    {
        public void Executar()
        {
            Console.WriteLine("\n📋 1. EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS");
            Console.WriteLine("=============================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Declaração de variáveis básicas
            // ===================================================
            // Objetivo: Aprender a criar variáveis com os tipos mais comuns
            // string → guarda texto
            // int → guarda números inteiros
            // bool → guarda verdadeiro (true) ou falso (false)
            Console.WriteLine("📝 Exercício 1: Variáveis básicas");
                int exercicio1 = 1;
                string nome = "Ricardo";
                int idade = 38;
                bool aprendizDeProgramacao = true;
                string descricaoDoNivel = "Aprendiz de Programação";
                Console.WriteLine();

            Console.WriteLine($"Exercício {exercicio1}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Aprendiz de Programação: {aprendizDeProgramacao}");
            Console.WriteLine($"Nível: {descricaoDoNivel}");
                
       
 
            // ===================================================
            // EXERCÍCIO 2: Reatribuição de valores
            // ===================================================
            // Objetivo: Mostrar que variáveis podem receber novos valores
            // A mesma variável pode guardar um valor diferente mais tarde
            Console.WriteLine("📝 Exercício 2: Reatribuição de valores");
            Console.WriteLine("--------------------------------");
                int exercicio2 = 2;
                int classificacaoDoNivel = 1;
                string curso = "Programação e Algoritmia";
                string modulo = "Desenvolver Algoritmos";
                bool estaPreparado = false;
                bool precisaDeAprender = true;  
            Console.WriteLine($"Exercício: {exercicio2}");
            Console.WriteLine($"Nível: {classificacaoDoNivel} -> {descricaoDoNivel}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Módulo: {modulo}");
            Console.WriteLine($"Está preparado?: {estaPreparado}");
            Console.WriteLine($"Precisa de aprender?: {precisaDeAprender}");
            Console.WriteLine();                     
            
 
            // ===================================================
            // EXERCÍCIO 3: Tipo object (equivalente ao any)
            // ===================================================
            // Objetivo: Entender que o tipo object pode guardar qualquer coisa
            // É como uma caixa que pode conter diferentes tipos de objetos
            Console.WriteLine("📝 Exercício 3: Flexibilidade do tipo object");
            Console.WriteLine("-----------------------------");
 
 
 
            // ===================================================
            // DEMONSTRAÇÃO ADICIONAL DE TIPOS
            // ===================================================
            // Objetivo: Conhecer mais tipos disponíveis em C#
            // double → números decimais (com vírgula)
            // char → um único caractere (letra)
            // decimal → números decimais com alta precisão (usado para dinheiro)
            Console.WriteLine("📝 Demonstração adicional de tipos");
            Console.WriteLine("-----------------------------");
                
                object valor;
                valor = 1;
                Console.WriteLine("Exercício: " + valor);
                valor = "Que idade tens?";
                Console.WriteLine("Perguntei: " + valor);
                valor = 38;
                Console.WriteLine("Respondeu: " + valor);
                valor = "Estás a gostar do curso?";
                Console.WriteLine("Perguntei: " + valor);
                valor = true;
                Console.WriteLine("Respondeu: " + valor);
 
           
        }
    }
