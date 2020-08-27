Feature: Jugar una simple partida de Piedras Papel Tijeras
    Como jugador
    Quiero jugar una partida
    para poder probar mi suerte

Scenario: Computadora escoge roca y el jugador escoge papel
    Given la computadora escoge secretamente roca
    When Yo escojo papel
    Then el resultado deberia ser "Jugador Ganador!"

Scenario: Computadora escoge roca y el jugador escoge tijeras
    Given la computadora escoge secretamente roca
    When Yo escogo tijeras
    Then el resultado deberia ser "Computadora Gana!"