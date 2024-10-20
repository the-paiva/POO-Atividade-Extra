// Arquivo referente aos códigos da questão 7 da Atividade Extra

/*Considerando o exemplo da classe Retangulo dos slides, implemente um método
adicional chamado que calcule o perímetro do retângulo. Teste os métodos do
retângulo.*/

using questao7.models;

void main()
{
    Retangulo retangulo1 = new()
    {
        L1 = 10,
        L2 = 20
    };

    Console.WriteLine("Questão 7");
    Console.WriteLine($"\nLado1 do retângulo: {retangulo1.L1}\nLado2 do retângulo: {retangulo1.L2}");
    Console.WriteLine($"Área do retângulo: {retangulo1.CalcularArea():0.00}");
    Console.WriteLine($"Perímetro do retângulo: {retangulo1.CalcularPerimetro():0.00}");
}

main();
