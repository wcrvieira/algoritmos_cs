// Algoritmo que testa o login e senha de um usuário
// e tentativas
// Declaração das variáveis
string senha = "Hoje2505#";
string usuario = "root";
int contador = 0;

while (contador < 3) // Condição para exibir as perguntas
{
    if (contador == 3) // Compara o contador com o nº de tentativas
    {
       Console.WriteLine("Número de tentativas excedido!!!"); 
    }

    // Interação com o usuário
    Console.Write("Informe o usuário: ");
    string user = Console.ReadLine();

    Console.Write("Digite a senha: ");
    string password = Console.ReadLine();

    if (usuario == user & senha == password)
    {
        Console.WriteLine("Seja bem-vindo ao sistema");
        break;
    }
    else
    {
        Console.WriteLine("Acesso negado");
    }
    contador = contador + 1; // contador += 1; contador++;

    if (contador == 3)
    {
       Console.WriteLine("Número de tentativas excedido!!!"); 
    }
    
}
