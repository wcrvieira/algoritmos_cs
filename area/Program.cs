/* Fazer um algoritmo que calcule a área do círculo, onde o usuário
   fornece o valor do raio
*/
// Declaração das variáveis
using System.Diagnostics;

double raio = 0.0;
double area = 0.0;
double pi = 3.14159;

// Interação com o usuário
Console.WriteLine("----- Cálculo da área de um círculo -----");
Console.Write("Informe o valor do raio do círculo: ");
raio = Convert.ToDouble(Console.ReadLine());

// Cálculo da área
area = pi * (raio * raio);

// Exibir o resultado no terminal
// Interpolação de strings (textos)
Console.WriteLine($"O valor da área do círculo é {area:f3}");