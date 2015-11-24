<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <h1>Criar ator para gerenciar interação do usuário com o aplicativo</h1>
    <p>
        Esta classe deverá representar um ator que terá como obrigação iniciar o sistema, receber comandos de exibição e finalizar a aplicação. Implementar nesta classe:<br />
        <ol>
            <li>Adicionar nova classe chamada <code>ConsoleCoordinatorActor</code></li>
            <li>Método <code>OnReceive()</code> esperando mensagens: "iniciar","reproduzir","finalizar"</li>
            <li>Construtor da classe deve receber um ator <code>ConsoleWriteActor</code></li>
            <li>Mensagem do tipo "iniciar" deve mostrar instruções mandando mensagens para o ator <code>ConsoleWriterActor</code> em amarelo e posteriormente mensagem para o próprio ator dizendo "continuar"</li>
            <li>Mensagem do tipo "continuar" deve ler do teclado uma opção do usuário e enviar uma mensagem para o própio ator repassando a mensagem</li>
            <li>Mensagem do tipo "finalizar" deve fechar todo o ActorSystem</li>
        </ol>
    </p>
    <h1>Implementar novos tipos de mensagem em <code>ConsoleWriterActor</code></h1>
    <p>
        <ol>
            <li>Criar novo tipo de mensagem, <code>EscreverEmAmareloMensagem</code> dentro da região de mensagens</li>
            <li>Implementar tratamento destas mensagens no construtor da classe</li>
        </ol>
    </p>
    <h1>Alterar <code>Program</code></h1>
    <p>
        <ol>
            <li>Criar novo ator representando <code>ConsoleCoordinatorActor</code></li>
            <li>Mandar mensagem para o ator <code>ConsoleCoordiantorActor</code> dizendo para o programa iniciar.</li>
        </ol>
    </p>    
</body>
</html>