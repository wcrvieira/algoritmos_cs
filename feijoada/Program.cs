// Algoritmo que verifica se um número inteiro é negativo
// ou não e se é divisível por ele mesmo

// Declaração de variável
int numero = 0;

// Interação com o usuário
Console.Write("Por favor, digite um número inteiro: ");
numero = Convert.ToInt16(Console.ReadLine());

if (numero < 0 & numero % 2 == 0) {
    Console.WriteLine($"O número {numero} é negativo e divisível por 2");
}

else
{
    Console.WriteLine($"O número {numero} está incorreto");
}