// Arquivo referente aos códigos da questão 8 da atividade extra

/*Crie uma classe Circulo que possua um atributo raio. Crie dois métodos que
calculam a área e o perímetro. Instancie um objeto dessa classe, atribua um valor
ao raio e exiba a área e o perímetro chamando os dois métodos definidos.*/

using System.Globalization;
using questao8.models;


static void main()
{
    string? input;

    Console.WriteLine("Questão 8");
    Console.Write("\n> Digite um valor para o atributo Raio do círculo: ");
    input = Console.ReadLine();

    Circulo circulo = new()
    {
        Raio = Convert.ToDouble(input, CultureInfo.InvariantCulture)
    };

    Console.WriteLine($"\nRaio: {circulo.Raio:0.00}");
    Console.WriteLine($"Área: {circulo.CalcularArea():0.00}");
    Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro():0.00}");
}


main();
