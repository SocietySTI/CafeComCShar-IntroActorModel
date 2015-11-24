<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <h1>Este aplicativo implementa as seguintes alterações</h1>
	<h2>Ator para coordenar trabalho na interface</h2>
    <p>
        A classe <code>ConsoleCoordinatorActor</code> realiza o trabalho de coordenação das atividades dentro do sistema.<br />
		Através de mensagens específicas é possível gerenciar a vida do aplicativo, iniciando, gerenciando tarefas e finalizando o mesmo.<br/>
		A seguir, as mensagens que são tratadas pelo <code>ConsoleCoordinatorActor</code>: <br/>
        <ul>
            <li>Tratar mensagem do tipo <code>String</code> com conteúdo <b>"iniciar"</b> que irá inicializar mensagens e colocar <code>ConsoleCoordinatorActor</code> aguardando entrada de usuário.</li>
            <li>Mensagens do tipo <code>String</code> com conteúdo <b>"reproduzir"</b> neste momento são tratadas, porém eu comportamento não foi implementado.</li>
			<li>Ao receber mensagens do tipo <code>String</code> com conteúdo <b>"sair"</b> serão tratadas e farão o <code>ActorSystem</code> ser desligado.</li>
			<li>Qualquer outra mensagem do tipo <code>String</code> com qualquer outro conteúdo será tratado para que o <code>ConsoleCoordinatorActor</code> solicite ao usuário informar nova opção.</li>
        </ul>
    </p>
    <h2><code>ConsoleWriterActor</code> e mensagens específicas</h2>
    <p>
		A classe <code>ConsoleWriterActor</code> é responsável em realizar a escrita de textos no <code>Console</code>. Este objetivo é realizado, pois esta classe herda o comportamento da classe <code>ReceiveActor</code> para tratar mensagens epsecíficas. <br />
		Dentro da classe é implementada uma região <code>#region Mensagens deste Ator</code> que contém todas as mensagens para serem enviadas para este ator. As mensagens esperadas são:<br />        
		<ul>
            <li><code>EscreverEmVerdeMensagem</code> classe que informa para ser apresentada mensagem em verde.</li>
			<li><code>EscreverEmVermelhoMensagem</code> classe que informa para ser apresentada mensagem em vermelho.</li>            
			<li><code>EscreverEmAmareloMensagem</code> classe que informa para ser apresentada mensagem em amarelo.</li> 
			<li><code>EscreverEmRoxoMensagem</code> classe que informa para ser apresentada mensagem em roxo.</li> 
        </ul>
    </p>
	<p>
		
	</p>

    <h2>Alterar <code>Program</code></h2>
    <p>
        <ol>
            <li>Criar novo ator representando <code>ConsoleCoordinatorActor</code></li>
            <li>Mandar mensagem para o ator <code>ConsoleCoordiantorActor</code> dizendo para o programa iniciar.</li>
        </ol>
    </p>    
</body>
</html>