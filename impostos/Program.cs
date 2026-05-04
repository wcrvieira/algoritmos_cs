// Declaração de variáveis
double salario, porcentagem = 0;

// Solicitando o valor ao usuário
Console.Write("Informe o valor do salário: ");

// Convertendo o texto digitado pelo usuário em um inteiro ou ponto flutuante
salario = Convert.ToDouble(Console.ReadLine());

// Outra forma de conversão de texto para inteiro ou ponto flutuante
//salario = double.Parse(Console.ReadLine());

if (salario >= 4500)
{
    porcentagem = salario * 0.28;
    Console.WriteLine($"O valor dos impostos é {porcentagem:F2}");
}
else if (salario >= 3000.01)
{
    porcentagem = salario * 0.18;
    Console.WriteLine($"O valor dos impostos é {porcentagem:F2}");
}
else if (salario >= 2000.01) {
    porcentagem = salario * 0.08;
    Console.WriteLine($"O valor, agora, é {porcentagem:F2}");
}
 else
 {
    Console.WriteLine("Isento");
}