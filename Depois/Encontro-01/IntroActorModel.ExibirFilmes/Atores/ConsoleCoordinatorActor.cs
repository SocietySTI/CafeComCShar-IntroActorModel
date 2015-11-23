using Akka.Actor;
using System;

namespace IntroActorModel.ExibirFilmes.Atores
{
    public class ConsoleCoordinatorActor : UntypedActor
    {
        private IActorRef _consoleWriterActor;

        public ConsoleCoordinatorActor(IActorRef consoleWriterActor)
        {
            _consoleWriterActor = consoleWriterActor;
        }

        protected override void OnReceive(object message)
        {
            if (message is String)
            {
                if (message.Equals("iniciar"))
                    ExibirInstrucoes();
                else if (message.Equals("reproduzir"))
                    ReproduzirFilme();
                else if (message.Equals("sair"))
                    FinalizarSistema();
                else
                    GetOpcaoSelecionada();
            }
        }

        private void GetOpcaoSelecionada()
        {
            _consoleWriterActor.Tell(new ConsoleWriterActor.EscreverEmAmareloMensagem("Informe opção desejada:"));
            var opcaoDesejada = Console.ReadLine();
            Self.Tell(opcaoDesejada);
        }

        private void ExibirInstrucoes()
        {
            // Usar o ator de consoleWriter para enviar mensagens que serão escritas.
            _consoleWriterActor.Tell(new ConsoleWriterActor.EscreverEmAmareloMensagem("-> Digite <reproduzir> para iniciar a reprodução de um filme."));
            _consoleWriterActor.Tell(new ConsoleWriterActor.EscreverEmAmareloMensagem("-> Digite <sair> para finalizar."));

            // Enviar mensagem para o proprio ator solicitando que continue o processamento.
            Self.Tell("continuar");
        }        

        private void ReproduzirFilme()
        {
            _consoleWriterActor.Tell(new ConsoleWriterActor.EscreverEmVermelhoMensagem("Deve ser implementado"));
            // Enviar mensagem para o proprio ator solicitando que continue o processamento.
            Self.Tell("continuar");
        }

        private void FinalizarSistema()
        {
            // Finalizar todo o ActorSystem (permite que o processo termine)
            Context.System.Shutdown();
        }
    }
}
