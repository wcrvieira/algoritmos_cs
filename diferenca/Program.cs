/* Fazer um algoritmo para ler quatro valores inteiros A, B, C e D.
   A seguir, calcule a diferença de (A * B) - (C * D)   
*/

// Declaração das variáveis
int A = 0;
int B = 0;
int C = 0;
int D = 0;

// Interação com o usuário
Console.WriteLine("*** Diferença entre produtos ***");
Console.Write("Digite o primeiro número inteiro: ");
A = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o segundo número inteiro: ");
B = Convert.ToInt16(Console.ReadLine());

Console.Write("Digite o terceiro número inteiro: ");
C = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o quarto número inteiro: ");
D = Convert.ToInt16(Console.ReadLine());

int diferenca = (A * B) - (C * D);

Console.WriteLine($"O valor da difereça é {diferenca}");
