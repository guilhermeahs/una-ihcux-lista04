using System;

// --- IHC: Prevenção de Erros (5ª Heurística de Nielsen) ---
Console.Clear();
Console.WriteLine("=== SISTEMA DE CADASTRO EXPERT ===");

try 
{
    Console.Write("\nDigite sua idade para continuar: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    string entrada = Console.ReadLine();

    // Tentativa de conversão (Onde o erro pode acontecer)
    int idade = int.Parse(entrada);
    int idadeMinima = 18;

    if (idade < idadeMinima)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n❌ Acesso negado! Idade {idade} não atinge a mínima de {idadeMinima} anos.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n✅ Acesso liberado! Idade {idade} registrada com sucesso.");
    }
}
catch (FormatException)
{
    // Feedback amigável em vez de um erro técnico
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n[ERRO DE UX]: Você digitou letras em um campo que só aceita números!");
    Console.WriteLine("DICA: Tente novamente inserindo apenas algarismos (ex: 25).");
}
finally
{
    Console.ResetColor();
    Console.WriteLine("\n-------------------------------------------");
    Console.WriteLine("O sistema encerrou a tentativa de operação.");
    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}