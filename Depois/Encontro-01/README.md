<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <h1>Este aplicativo implementa as seguintes altera��es</h1>
	<h2>Ator para coordenar trabalho na interface</h2>
    <p>
        A classe <code>ConsoleCoordinatorActor</code> realiza o trabalho de coordena��o das atividades dentro do sistema.<br />
		Atrav�s de mensagens espec�ficas � poss�vel gerenciar a vida do aplicativo, iniciando, gerenciando tarefas e finalizando o mesmo.<br/>
		A seguir, as mensagens que s�o tratadas pelo <code>ConsoleCoordinatorActor</code>:
    </p>
	<ul>
        <li>Tratar mensagem do tipo <code>String</code> com conte�do <b>"iniciar"</b> que ir� inicializar mensagens e colocar <code>ConsoleCoordinatorActor</code> aguardando entrada de usu�rio.</li>
        <li>Mensagens do tipo <code>String</code> com conte�do <b>"reproduzir"</b> neste momento s�o tratadas, por�m eu comportamento n�o foi implementado.</li>
		<li>Ao receber mensagens do tipo <code>String</code> com conte�do <b>"sair"</b> ser�o tratadas e far�o o <code>ActorSystem</code> ser desligado.</li>
		<li>Qualquer outra mensagem do tipo <code>String</code> com qualquer outro conte�do ser� tratado para que o <code>ConsoleCoordinatorActor</code> solicite ao usu�rio informar nova op��o.</li>
	</ul>
    <h2><code>ConsoleWriterActor</code> e mensagens espec�ficas</h2>
    <p>
		A classe <code>ConsoleWriterActor</code> � respons�vel em realizar a escrita de textos no <code>Console</code>. Este objetivo � realizado, pois esta classe herda o comportamento da classe <code>ReceiveActor</code> para tratar mensagens epsec�ficas. <br />
		Dentro da classe � implementada uma regi�o <code>#region Mensagens deste Ator</code> que cont�m todas as mensagens para serem enviadas para este ator. As mensagens esperadas s�o:
    </p>
	<ul>
		<li><code>EscreverEmVerdeMensagem</code> classe que informa para ser apresentada mensagem em verde.</li>
		<li><code>EscreverEmVermelhoMensagem</code> classe que informa para ser apresentada mensagem em vermelho.</li>
		<li><code>EscreverEmAmareloMensagem</code> classe que informa para ser apresentada mensagem em amarelo.</li>
		<li><code>EscreverEmRoxoMensagem</code> classe que informa para ser apresentada mensagem em roxo.</li>
	</ul>
	<p>
		As classes <code>EscreverEmVerdeMensagem</code>, <code>EscreverEmVermelhoMensagem</code> e <code>EscreverEmAmareloMensagem</code> s�o tratadas no construtor da classe <code>ConsoleWriterActor</code>, atr�ves do m�todo <code>Receive<T>()</code>.
	</p>
    <h2>Atualizar <code>Program</code> para mudar foco do gerenciamento da aplica��o</h2>
    <p>
        A classe <code>Program</code> deve iniciar o <code>ActorSystem</code> e mandar a primeira mensagem, com o conte�do <b>"iniciar"</b> para o ator <code>ConsoleCoordinatorActor</code>.<br />
		Ainda o <code>Program</code> n�o pode ser finalizado, nem o <code>ActorSystem</code>. Para isso � utilizado o m�todo <code>AwaitTermination()</code> para gerenciar isto.
    </p>
</body>
</html>