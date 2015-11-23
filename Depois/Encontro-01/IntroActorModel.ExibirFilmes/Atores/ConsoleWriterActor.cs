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

        public class EscreverEmVermelhoMensagem : Escrever
        {
            public EscreverEmVermelhoMensagem(string mensagem) : base(mensagem) { }
        }

        public class EscreverEmAmareloMensagem : Escrever
        {
            public EscreverEmAmareloMensagem(string mensagem) : base(mensagem) { }
        }

        #endregion

        public ConsoleWriterActor()
        {
            // Lidando com mensagens fortemente tipadas
            Receive<EscreverEmVerdeMensagem>(mensagem => HandleEscreverEmVerde(mensagem));
            Receive<EscreverEmAmareloMensagem>(mensagem => HandleEscreverEmAmarelo(mensagem));
            Receive<EscreverEmVermelhoMensagem>(mensagem => HandleEscreverEmVermelho(mensagem));
        }

        private void HandleEscreverEmVerde(EscreverEmVerdeMensagem mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            EscreverMensagem(mensagem.Mensagem);
        }

        private void HandleEscreverEmAmarelo(EscreverEmAmareloMensagem mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            EscreverMensagem(mensagem.Mensagem);
        }

        private void HandleEscreverEmVermelho(EscreverEmVermelhoMensagem mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            EscreverMensagem(mensagem.Mensagem);
        }

        private void EscreverMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }

}
