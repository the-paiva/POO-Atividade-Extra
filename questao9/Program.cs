// Arquivo referente aos códigos da questão 9 da atividade extra

/*Crie uma classe chamada SituacaoFinanceira com os atributos valorCreditos e
valorDebitos. Crie um método chamado calcularSaldo() que retorna/calcula a
diferença entre crédito e débito. Instancie uma classe SituacaoFinanceira, inicialize
os dois atributos e exiba o resultado do método calcularSaldo().*/

using System.Globalization;
using questao9.models;


// Pede um valor do tipo decimal
decimal pedirDecimal(string? mensagemDeInput)
{
    Console.Write(mensagemDeInput);
    string? input = Console.ReadLine();
    return Convert.ToDecimal(input, CultureInfo.InvariantCulture);
}


void main()
{
    Console.WriteLine("Questão 8");

    SituacaoFinanceira situacaoFinanceira = new()
    {
        ValorCreditos = pedirDecimal("\n> Digite o valor atual do seu crédito: R$ "),
        ValorDebitos = pedirDecimal("> Digite o valor atual do seu débito: R$ ")
    };

    Console.WriteLine($"\nSaldo: R$ {situacaoFinanceira.CalcularSaldo():0.00}");
    Console.WriteLine(situacaoFinanceira.RetornarEstadoDeSaldo());
}

main();
