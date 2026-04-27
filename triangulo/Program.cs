/* Fazer um algoritmo que leia três valores com ponto flutuante de dupla
   precisão: A, B e C e calcule as áreas
*/

// Declaração das variáveis
int A = 0;
int B = 0;
int C = 0;

// Interagindo com o usuário
Console.WriteLine("*** Cálculo de áreas usando um triângulo ***");
Console.Write("Informe o valor do lado A: ");
A = Convert.ToInt16(Console.ReadLine());

Console.Write("Digite o valor do lado B: ");
B = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o valor do lado C: ");
C = Convert.ToInt16(Console.ReadLine());

// Cálculo da área do triângulo retângulo
float area_triangulo = (A * B) / 2;
Console.WriteLine($"A área do triângulo é igual a {area_triangulo:f2}");

// Cálculo do círculo de raio do lado C - pi = 3.14.159
double pi = 3.14159;
double area_circulo = pi * Math.Pow(C, 2) ;
Console.WriteLine($"A área do raio do lado C é igual a {area_circulo:f3}");

// Cálculo do trapézio que tem A e B por bases e C por altura
float area_trapezio = ((A + B) * C)/2;
Console.WriteLine($"A área do trapézio é {area_trapezio:f2}");

// Cálculo da área do quadrado que tem lado B
int area_quadrado = B * B;
Console.WriteLine($"A área do quadrado do lado B é {area_quadrado}");

// Cálculo da área do retângulo que tem lados A e B
int area_retangulo = A * B;
Console.WriteLine($"A área do retângulo A e B é {area_retangulo}");

Console.WriteLine("*** Fim do Algoritmo ***");