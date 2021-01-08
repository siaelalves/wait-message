# wait-message
É um contador de tempo para MS-DOS de segundos, minutos, horas, dias e semanas. Precisa de correção.
.
Execute o prompt de comando diretamente na pasta do aplicativo.
Os argumentos são os seguintes:

wait [time] [second|minute|hour|day|week] [msg]

O argumento [msg] precisa estar entre aspas.
Dentro do argumento [msg], utilize "<t>" para exibir o tempo percorrido.
O problema que precisa ser corrigido é a exibição do tempo na variável "<t>".

Precisa de correção:
#1: A expressão "<t>" só exibe o tempo em segundos, mesmo que você utilize o argumento "minute", "hour", "day" ou "week".
#2: Ao chegar no útilmo segundo, é necessário criar um método que remova o plural do tempo. Por exemplo, "2 segundos...1 segundo(s)".
