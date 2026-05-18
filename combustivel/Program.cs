/* Algoritmo que recebe um menu de opções de combustíveis e conta
    quantos clientes abasteceram em cada opção */
// Declaração das variáveis
int opcao = 0;
int alcool = 0, gasolina = 0, diesel = 0;

Console.WriteLine("Menu de combustíveis");
Console.WriteLine("Digite 1 para Alcool" + "\n" +
                  "Digite 2 para Gasolina" + "\n" +
                  "Digite 3 para Diesel" + "\n" +
                  "Digite 4 para encerrar o sistema!");
while (opcao != 4)
{
    Console.Write("Entre com sua opção: ");

    opcao = Convert.ToInt16(Console.ReadLine());
    switch (opcao)
    {
        case 1: alcool++; break; // alcool =+1 ou alcool = alcool + 1
        case 2: gasolina++; break; // gasolina += 1 ou gasolina = gasolina + 1
        case 3: diesel++; break; // diesel += 1 ou diesel = diesel + 1
        case 4:
            Console.WriteLine("" + "\n" + "Fim. Obrigado pela preferência!" + "\n" +
                                  "Total de veículos com Alcool: " + alcool + "\n" +
                                  "Total de veículos com Gasolina: " + gasolina + "\n" +
                                  "Total de veículos com Diesel: " + diesel);
        break;
        default: Console.WriteLine("Código inválido"); break;
    }
}
