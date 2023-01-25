using HexagonalArchitectureExample.Business;
using HexagonalArchitectureExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchitectureExample.Domain
{
    public class Game
    {
        private GameEngine _gameEngine;
        private IInputPort _inputPort;
        private IOutputPort _outputPort;

        public Game(GameEngine gameEngine, IInputPort inputPort, IOutputPort outputPort)
        {
            _gameEngine = gameEngine;
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        public void Run()
        {
            _inputPort.ReadInput();
            _gameEngine.StartGame();
            _outputPort.WriteOutput("Jogo iniciado!");
        }
    }
}
