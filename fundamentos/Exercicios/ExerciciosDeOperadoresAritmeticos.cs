using System;
 
namespace FundamentosAlgoritmia;
 
/// <summary>
/// 🧮 SUMÁRIO DOS EXERCÍCIOS DE OPERADORES ARITMÉTICOS
/// =================================================
///
/// Exercício 1: Soma e subtração
/// - Aprender a usar os operadores + (soma) e - (subtração)
/// - Guardar o resultado em variáveis
/// - Exibir os resultados no console
///
/// Exercício 2: Cálculo de área do retângulo
/// - Aplicar a multiplicação (*) em um problema real
/// - Calcular área = largura × altura
/// - Trabalhar com números decimais (double)
///
/// Exercício 3: Operador módulo (resto da divisão)
/// - Entender o operador % que retorna o resto da divisão
/// - Exemplo prático: 20 ÷ 6 = 3, resto 2
/// - Útil para verificar se um número é par ou ímpar
///
/// Demonstração adicional:
/// - Multiplicação e divisão com conversão de tipos (cast)
/// - Operador de incremento (++) que aumenta o valor em 1
/// - Formatação de números decimais com :F2 (2 casas decimais)
/// </summary>
///
 
 
 
/**
� 2. EXERCÍCIOS DE OPERADORES ARITMÉTICOS
=========================================
 
� Exercício 1: Soma e subtração
8 + 5 = 13
8 - 5 = 3
 
� Exercício 2: Cálculo de área do retângulo
Área do retângulo: 5 × 3 = 15
 
� Exercício 3: Operador módulo (resto da divisão)
Resto da divisão de 20 por 6 = 2
 
� Demonstração adicional de operadores
8 × 5 = 40
8 ÷ 5 = 1.60
Incremento de 8: 9
*/
 
public class ExerciciosOperadoresAritmeticos
{
  public void Executar()
  {
    Console.WriteLine("\n🧮 3. EXERCÍCIOS DE OPERADORES ARITMÉTICOS");
    Console.WriteLine("=========================================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Soma e subtração
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis numéricas
    // 2. Fazer uma soma usando +
    // 3. Fazer uma subtração usando -
    // 4. Mostrar os resultados no console
    //
    // 💡 Regra:
    // + → soma valores
    // - → subtrai valores
 
    Console.WriteLine("📝 Exercício 1: Soma e subtração");
 
    int numero1 = 8;
    int numero2 = 5;
 
    int soma = numero1 + numero2;
    int subtracao = numero1 - numero2;
 
    Console.WriteLine($"Soma: {numero1} + {numero2} = {soma}");
    Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}\n");
 
 
    // ===================================================
    // EXERCÍCIO 2: Cálculo de área
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar duas variáveis (largura e altura)
    // 2. Multiplicar os valores
    // 3. Mostrar o resultado
    //
    // 💡 Regra:
    // Área do retângulo = largura × altura
    // Usamos double para valores com casas decimais
 
    Console.WriteLine("📝 Exercício 2: Cálculo de área do retângulo");
 
    double largura = 5.0;
    double altura = 3.0;
 
    double area = largura * altura;
 
    Console.WriteLine($"Área: {largura} × {altura} = {area}\n");
 
 
    // ===================================================
    // EXERCÍCIO 3: Operador módulo (%)
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar dois números inteiros
    // 2. Usar o operador % para obter o resto
    // 3. Mostrar o resultado
    //
    // 💡 Regra:
    // % retorna o RESTO da divisão
 
    Console.WriteLine("📝 Exercício 3: Operador módulo (%)");
 
    int dividendo = 20;
    int divisor = 6;
 
    int resto = dividendo % divisor;
 
    Console.WriteLine($"Resto de {dividendo} ÷ {divisor} = {resto}\n");
 
 
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
 
    int multiplicacao = numero1 * numero2;
    double divisao = (double)numero1 / numero2;
 
    Console.WriteLine($"Multiplicação: {numero1} × {numero2} = {multiplicacao}");
    Console.WriteLine($"Divisão: {numero1} ÷ {numero2} = {divisao:F2}\n");
 
 
    // ===================================================
    // EXERCÍCIO 5: Incremento
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar uma variável
    // 2. Usar o operador ++
    // 3. Mostrar o valor antes e depois
    //
    // 💡 Regra:
    // ++ aumenta o valor em 1
 
    Console.WriteLine("📝 Exercício 5: Incremento");
 
    int incremento = numero1;
 
    Console.WriteLine($"Valor original: {incremento}");
 
    incremento++;
 
    Console.WriteLine($"Após incremento (++): {incremento}\n");
 
 
    // ===================================================
    // RESUMO FINAL
    // ===================================================
    // 👉 Objetivo:
    // Relembrar os principais operadores
 
    Console.WriteLine("📌 Resumo dos operadores:");
    Console.WriteLine("+  → soma");
    Console.WriteLine("-  → subtração");
    Console.WriteLine("*  → multiplicação");
    Console.WriteLine("/  → divisão");
    Console.WriteLine("%  → resto da divisão");
    Console.WriteLine("++ → incremento");
 
    Console.WriteLine();
  }
 
}
 
 