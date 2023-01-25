# Hexagonal Architecture Example

Neste exemplo, o núcleo hexagonal é a classe "GameEngine", que contém a lógica de negócios para iniciar um jogo. Ele é rodeado por interfaces "IInputPort" e "IOutputPort", que são implementadas pelos adapters "KeyboardInputAdapter" e "ConsoleOutputAdapter", respectivamente. A classe "Game" é responsável por criar instâncias dessas classes e usá-las para iniciar o jogo.

O padrão hexagonal permite que a lógica de negócios do jogo seja isolada das suas dependências de entrada e saída, permitindo que essas dependências sejam facilmente trocadas sem afetar a lógica de negócios. Além disso, os adapters podem ser testados isoladamente, sem precisar testar a lógica de negócios do jogo.

### Vamos analisar cada parte do código acima para entender como ele implementa o padrão hexagonal:

- GameEngine: Esta é a classe que representa o núcleo hexagonal. Ele contém a lógica de negócios do jogo, nesse caso, o método "StartGame()" que inicia o jogo. Ele não tem conhecimento das dependências de entrada e saída do jogo.

- IInputPort e IOutputPort: Essas são as interfaces que representam os ports. Eles expõem as funcionalidades que o núcleo hexagonal precisa para ler a entrada e escrever a saída do jogo. Essas interfaces são implementadas pelos adapters.

- KeyboardInputAdapter e ConsoleOutputAdapter: Essas são as classes que implementam as interfaces "IInputPort" e "IOutputPort", respectivamente. Elas fornecem a implementação concreta das funcionalidades expostas pelas interfaces, nesse caso, ler a entrada do teclado e escrever a saída na console.

- Game: Esta é a classe que usa o núcleo hexagonal e os adapters. Ela cria instâncias dessas classes e usa-as para iniciar o jogo. Ela lê a entrada, chama o método "StartGame()" do núcleo hexagonal, e escreve a saída.

### Conclusão

Com essa arquitetura, a lógica de negócios do jogo está isolada das suas dependências de entrada e saída, o que permite que essas dependências sejam facilmente trocadas sem afetar a lógica de negócios. Além disso, os adapters podem ser testados isoladamente, sem precisar testar a lógica de negócios do jogo.

Esse é um exemplo simples e geral, mas a arquitetura hexagonal pode ser aplicada em diversos tipos de sistemas e aplicações. E é uma boa prática para manter a coesão e acoplamento baixo, e facilitar testes e mudanças futuras.
