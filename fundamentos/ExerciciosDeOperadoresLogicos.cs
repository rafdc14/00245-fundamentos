using System;
 
namespace FundamentosAlgoritmia;
 
/// <summary>
/// 🔗 SUMÁRIO DOS EXERCÍCIOS DE OPERADORES LÓGICOS
/// ===============================================
///
/// Exercício 1: Operador AND (&&) - "E"
/// - Ambas as condições devem ser verdadeiras
/// - Exemplo: podeDirigir = temIdade E temCarta
/// - Se uma for falsa, o resultado é falso
///
/// Exercício 2: Operador OR (||) - "OU"
/// - Pelo menos uma condição deve ser verdadeira
/// - Exemplo: acessoPermitido = estaLogado OU ehAdmin
/// - Se ambas forem falsas, o resultado é falso
///
/// Exercício 3: Operador NOT (!) - "NÃO"
/// - Inverte o valor booleano
/// - Exemplo: !true = false, !false = true
/// - Útil para negar uma condição
///
/// Demonstração adicional:
/// - Combinações de operadores lógicos
/// - Tabelas verdade do AND (&&)
/// - Tabelas verdade do OR (||)
/// </summary>
 
/// SAIDA na Tela  ou Resultado esperado
 
 
 
 
 
 
 
public class ExerciciosOperadoresLogicos
{
  public void Executar()
  {
    Console.WriteLine("\n🔗 2. EXERCÍCIOS DE OPERADORES LÓGICOS");
    Console.WriteLine("====================================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Operador AND (&&)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis booleanas (true/false)
    //1A. Criar outra variavel que receberá os valores Ex:     bool podeDirigir = temIdade && temCarta; // true && false = false
    // 2. Usar o operador && (AND)
    // 3. Mostrar o resultado no console
    //
    // 💡 Regra:
    // AND (&&) só retorna TRUE se TODAS as condições forem TRUE
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
    Console.WriteLine("------------------------------------");
    Console.WriteLine("📝 Exercício 1: Operador AND (&&)");
    Console.WriteLine("-----------------------------------");
 
    /**
    SAIDA na Tela  ou Resultado esperado
�   Exercício 1: Operador AND (&&)
    Tem idade? True
    Tem carta? False
     Pode dirigir? (True && False) = False
    */

    string nome = "Ricardo";
    int idade = 38;
    bool preencheRequisitos = true;
    bool temDiploma = false;
    bool podeConcorrer = preencheRequisitos && temDiploma;
    bool precisaDeCurso = preencheRequisitos && !temDiploma; // true && true = true

    Console.WriteLine();
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine();
    Console.WriteLine($"Preenche Requisitos?: {preencheRequisitos}");
    Console.WriteLine($"Tem Diploma?: {temDiploma}");
    Console.WriteLine($"Pode Concorrer?: {preencheRequisitos && temDiploma}");
    Console.WriteLine($"Precisa de curso?: {preencheRequisitos && !temDiploma}");
    Console.WriteLine();
 
 
 
    // ===================================================
    // EXERCÍCIO 2: Operador OR (||)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis booleanas
    // 1A. Criar outra variavel que RECEBERÁ os valores das outras 2 Ex:  bool acessoPermitido = estaLogado || ehAdmin;
    // 2. Usar o operador || (OR)
    // 3. Mostrar o resultado
    //
    // 💡 Regra:
    // OR (||) retorna TRUE se PELO MENOS UMA condição for TRUE
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
 
    Console.WriteLine("------------------------------------");
    Console.WriteLine("📝 Exercício 2: Operador OR (||)");
    Console.WriteLine("-----------------------------------");

    bool passouNaProvaDeGinástica = true;
    bool passouNaProvaDeFutebol = false;
    bool estáAprovado = passouNaProvaDeGinástica || passouNaProvaDeFutebol;

    Console.WriteLine();
    Console.WriteLine($"Passou na prova de ginástica? {passouNaProvaDeGinástica}");
    Console.WriteLine($"passou na prova de futebol? {passouNaProvaDeFutebol}");
    Console.WriteLine($"Está aprovado? {passouNaProvaDeGinástica || passouNaProvaDeFutebol}");
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine($"Preenche Requisitos?: {preencheRequisitos}");
    Console.WriteLine($"Tem Diploma?: {temDiploma}");
    Console.WriteLine($"Pode Concorrer?: {preencheRequisitos && temDiploma}");
    Console.WriteLine($"Precisa de curso?: {preencheRequisitos && !temDiploma}");
    Console.WriteLine($"Pode concorrer ao curso? {preencheRequisitos || temDiploma}");
    Console.WriteLine();
 
    /**
     SAIDA na Tela  ou Resultado esperado
   � Exercício 2: Operador OR (||)
    Está logado? False
    É admin? True
    Acesso permitido? (False || True) = True
    */
 
 
 
 
 
 
    // ===================================================
    // EXERCÍCIO 3: Operador NOT (!)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar uma variável booleana
    // 2. Usar o operador ! (NOT)
    // 3. Mostrar o valor original e o invertido
    //
    // 💡 Regra:
    // NOT (!) inverte o valor:
    // true → false
    // false → true
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
    Console.WriteLine("------------------------------------");
    Console.WriteLine("📝 Exercício 3: Operador NOT (!)");
    Console.WriteLine("-----------------------------------");

    bool temExperienciaDeTreino = true;
    bool temLimitacoesFisicas = false;
    bool planoDeTreinoEspecial = temExperienciaDeTreino && !temLimitacoesFisicas;

    Console.WriteLine();
    Console.WriteLine($"Tem experiência de treino? {temExperienciaDeTreino}");
    Console.WriteLine($"Tem limitações físicas? {temLimitacoesFisicas}");
    Console.WriteLine($"Precisa de plano de treino especial? {temExperienciaDeTreino && !temLimitacoesFisicas}");
    Console.WriteLine();
 
    /**SAIDA na Tela  ou Resultado esperado
     � Exercício 3: Operador NOT (!)
     Valor original: True
     Valor invertido: False = False
 
    */
 
 
 
    // ===================================================
    // EXERCÍCIO 4: Combinação de operadores
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar 3 variáveis booleanas
    // 2. Combinar AND (&&) e OR (||)
    // 3. Usar parênteses para controlar a lógica
    // 💡 Regra:
    // Parênteses definem a ordem da avaliação
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
 
    Console.WriteLine("------------------------------------");
    Console.WriteLine("📝 Exercício 4: Combinação de operadores");
    Console.WriteLine("-----------------------------------");

    bool chegouAHoras = true;
    bool temSenha = false;
    bool temVagas = true;
    bool podeParticipar = (chegouAHoras || temSenha) && temVagas;

    Console.WriteLine();
    Console.WriteLine($"Chegou a horas? {chegouAHoras}");
    Console.WriteLine($"Tem senha?  {temSenha}");
    Console.WriteLine($"Tem vagas? {temVagas}");
    Console.WriteLine($"Pode participar? {(chegouAHoras || temSenha) && temVagas}");
    Console.WriteLine();

 
    /**SAIDA na Tela  ou Resultado esperado
   � Exercício 4: Combinação de operadores
   Tem entrada? True
   Tem convite? False
    É VIP? True
    Pode entrar? ((True || False) && True) = True
    */
 
 
 
    // ===================================================
    // EXERCÍCIO 5: Tabela Verdade (Prática)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Testar todas as combinações possíveis
    // 2. Observar os resultados dos operadores
    //
    // 💡 Objetivo:
    // Entender completamente como os operadores funcionam
    // OBS: Use a Interpolação dentro do Console.WriteLine(?) para testar e passar os valores das Variaveis {...}
   
   Console.WriteLine("------------------------------------");
    Console.WriteLine("📝 Exercício 5: Tabela Verdade (Prática)");
    Console.WriteLine("-----------------------------------");
   
    Console.WriteLine("------------------------------------");
    Console.WriteLine("📊 Tabela verdade do operador AND (&&):");
    Console.WriteLine("-----------------------------------");
    
    /**SAIDA na Tela  ou Resultado esperado
   � Tabela verdade do operador AND (&&):
    true && true = True
    true && false = False
    false && true = False
    false && false = False
    */

    Console.WriteLine("------------------------------------");
    Console.WriteLine("\n📊 Tabela verdade do operador OR (||):");
    Console.WriteLine("-----------------------------------");

     /**SAIDA na Tela  ou Resultado esperado
    /*  � Tabela verdade do operador OR (||):
      true || true = True
      true || false = True
      false || true = True
      false || false = False
   */
 
  }
 
}
 