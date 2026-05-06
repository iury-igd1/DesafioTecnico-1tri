using System;

class Program
{
    static int calcularOfensiva (int forca, int agilidade) {
        return forca + agilidade;
    }

    static void Main(string[] args) {
        string nome1 = "Hulk";
        int forca1 = 8;
        int agilidade1 = 5;
        int inteligencia1 = 3;
        int vida1 = 20;

        string nome2 = "Homem de Ferro";
        int forca2 = 4;
        int agilidade2 = 6;
        int inteligencia2 = 9;
        int vida2 = 15;

        Console.WriteLine("- BATALHA -");

        Console.WriteLine($"{nome1} - Força: {forca1}, Agilidade: {agilidade1}, Inteligência: {inteligencia1}, Vida: {vida1}");
        Console.WriteLine("VS");
        Console.WriteLine($"{nome2} - Força: {forca2}, Agilidade: {agilidade2}, Inteligência: {inteligencia2}, Vida: {vida2}");
        Console.WriteLine("\nBatalha OFENSIVA: Ganha quem tiver maior força + agilidade!");
        
        Console.Write($"Determinando o vencedor em ");
        for (int i = 3; i >= 1; i--) {
            Console.Write($"{i}... ");
        }

        int ofensiva1 = calcularOfensiva(forca1, agilidade1);
        int ofensiva2 = calcularOfensiva(forca2, agilidade2);

        if (ofensiva1 > ofensiva2) {
            Console.WriteLine($"\n\n{nome1} foi o vencedor da batalha com {ofensiva1} pontos! {nome2} fez apenas {ofensiva2} pontos.");
        }
        else if (ofensiva2 > ofensiva1) {
            Console.WriteLine($"\n\n{nome2} foi o vencedor da batalha com {ofensiva2} pontos! {nome1} fez apenas {ofensiva1} pontos.");
        }
        else {
            Console.WriteLine($"\n\nEmpate entre os heróis! {ofensiva1} pontos para cada um.");
        }
    }
}