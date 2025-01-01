using LimeLexer.Episode1;

namespace LimeLexer;

internal class Program
{
    static void Main(string[] args)
    {
        Lexer lexer = new("let a: int = 3;");

        foreach (var tok in lexer.GetAllTokens())
        {
            Console.WriteLine(tok.Print());
        }
    }
}
