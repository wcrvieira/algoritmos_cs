// Algoritmo que testa senhas
// Declaração das variáveis
string senha = "@2026";
string password = "";

while (senha != password)
{
    Console.Write("Digite a senha do sistema: ");
    password = Console.ReadLine();

    /*if (senha == password) { Console.WriteLine("Acesso permitido!!!");}
        else {Console.WriteLine("Acesso negado!!!!!!");} */
    
    switch (password)
    {
        case "@2026": Console.WriteLine("Acesso permitido!!!"); break;
        default: Console.WriteLine("Acesso negado!"); break;
    }
}