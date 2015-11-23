using Akka.Actor;
using IntroActorModel.ExibirFilmes.Atores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroActorModel.ExibirFilmes
{
    class Program
    {
        private static ActorSystem SistemaStreamingFilmesActorSystem;

        static void Main(string[] args)
        {
            // Preciso rodar todos meus atores dentro de um ActorSystem
            SistemaStreamingFilmesActorSystem = ActorSystem.Create("SsitemaStreamingFilmes");
            Console.WriteLine("[INFO] ActorSystem Criado ....");

            // Criar uma "Forma" para posterior criação de um ator
            Props consoleWriterProps = Props.Create<ConsoleWriterActor>();
            // Criar uma referencia ao ator de reprodutor de straming
            IActorRef consoleWriterActor = SistemaStreamingFilmesActorSystem.ActorOf(consoleWriterProps, "writer");

            // Criar a forma (Props) e criar o ator para reproduzir filmes
            Props reprodutorStreamingProps = Props.Create<ReprodutorStreamingActor>(consoleWriterActor);
            IActorRef reprodutorStreamingActor = SistemaStreamingFilmesActorSystem.ActorOf(reprodutorStreamingProps, "player");

            // Mandar uma mensagem para o ator
            reprodutorStreamingActor.Tell(new ReprodutorStreamingActor.ReproduzirFilmeMensagem("Avengers", "1203"));

            // Não deixar a thread principal sair enquanto o Actor System não encerrar
            SistemaStreamingFilmesActorSystem.AwaitTermination();
        }
    }
}
