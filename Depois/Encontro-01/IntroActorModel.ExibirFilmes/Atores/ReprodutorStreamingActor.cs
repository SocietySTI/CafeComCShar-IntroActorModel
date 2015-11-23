using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroActorModel.ExibirFilmes.Atores
{
    public class ReprodutorStreamingActor : ReceiveActor
    {
        #region Mensagens deste Ator
        public class ReproduzirFilmeMensagem
        {
            public string TituloFilme { get; private set; }
            public string CodigoUsuario { get; private set; }

            public ReproduzirFilmeMensagem(string tituloFilme, string codigoUsuario)
            {
                TituloFilme = tituloFilme;
                CodigoUsuario = codigoUsuario;
            }
        }
        #endregion

        private IActorRef _atorParaEscritaEmTela;

        public ReprodutorStreamingActor(IActorRef atorParaEscritaEmTela)
        {
            _atorParaEscritaEmTela = atorParaEscritaEmTela;
            // Lidando com mensagens fortemente tipadas
            Receive<ReproduzirFilmeMensagem>(mensagem => HandleReproduzirFilme(mensagem));
        }

        private void HandleReproduzirFilme(ReproduzirFilmeMensagem mensagem)
        {
            string mensagemParaExibir = String.Format("Usuário {0} iniciou a reprodução do filme {1}", mensagem.CodigoUsuario, mensagem.TituloFilme);

            _atorParaEscritaEmTela.Tell(new ConsoleWriterActor.EscreverEmVerdeMensagem(mensagemParaExibir));
        }
    }
}
