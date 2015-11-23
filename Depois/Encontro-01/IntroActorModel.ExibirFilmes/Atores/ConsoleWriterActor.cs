using Akka.Actor;
using System;

namespace IntroActorModel.ExibirFilmes.Atores
{
    public class ConsoleWriterActor : ReceiveActor
    {
        #region Mensagens deste Ator

        public abstract class Escrever
        {
            public string Mensagem { get; private set; }
            protected Escrever(string mensagem)
            {
                Mensagem = mensagem;
            }
        }

        public class EscreverEmVerdeMensagem : Escrever
        {
            public EscreverEmVerdeMensagem(string mensagem) : base(mensagem) { }
        }

        public class EscreverEmVermelho : Escrever
        {
            public EscreverEmVermelho(string mensagem) : base(mensagem) { }
        }

        #endregion

        public ConsoleWriterActor()
        {
            Receive<EscreverEmVerdeMensagem>(mensagem => HandleEscreverEmVerde(mensagem)); 
        }

        private void HandleEscreverEmVerde(EscreverEmVerdeMensagem mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            EscreverMensagem(mensagem.Mensagem);
        }

        private void EscreverMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }

}
