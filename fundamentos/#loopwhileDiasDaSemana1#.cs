// using System;

// class Program
// {
//     static void Main()
//     {
//         int diaDaSemana;

//         while (true)
//         {
//             Console.Write("Escolha um número de 1 a 7: ");
//             diaDaSemana = Convert.ToInt32(Console.ReadLine());

//             if (diaDaSemana >= 1 && diaDaSemana <= 7)
//             {
//                 break; // sai do loop se for válido
//             }

//             Console.WriteLine("Número inválido! Tente novamente.\n");
//         }

//         switch (diaDaSemana)
//         {
//             case 1:
//                 Console.WriteLine("Domingo");
//                 break;
//             case 2:
//                 Console.WriteLine("Segunda-feira");
//                 break;
//             case 3:
//                 Console.WriteLine("Terça-feira");
//                 break;
//             case 4:
//                 Console.WriteLine("Quarta-feira");
//                 break;
//             case 5:
//                 Console.WriteLine("Quinta-feira");
//                 break;
//             case 6:
//                 Console.WriteLine("Sexta-feira");
//                 break;
//             case 7:
//                 Console.WriteLine("Sábado");
//                 break;
//         }
//     }
// }