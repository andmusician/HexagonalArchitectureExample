// See https://aka.ms/new-console-template for more information
using HexagonalArchitectureExample.Adapters;
using HexagonalArchitectureExample.Business;
using HexagonalArchitectureExample.Domain;
using HexagonalArchitectureExample.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        GameEngine gameEngine = new GameEngine();
        IInputPort inputPort = new KeyboardInputAdapter();
        IOutputPort outputPort = new ConsoleOutputAdapter();
        Game game = new Game(gameEngine, inputPort, outputPort);
        game.Run();
    }
}