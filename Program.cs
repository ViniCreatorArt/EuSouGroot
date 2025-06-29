const string FS = "tchau";

Console.WriteLine("--- Groot Chatbot ---\n");

string pergunta;
do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;

    string resposta = ObtemRespostaGroot(pergunta);

    ExibeResposta(ObtemRespostaGroot(pergunta));

} while (pergunta.Trim().ToLower() != FS);


void ExibeResposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"                          Resposta: {resposta}");
    Console.ResetColor();
}

string ObtemRespostaGroot(string pergunta)
{
    return pergunta.Trim().ToLower() == FS ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}
