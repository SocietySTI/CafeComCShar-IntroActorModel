using Akka.Actor;
using IntroActorModel.ExibirFilmes.Atores;
using System;

namespace IntroActorModel.ExibirFilmes
{
    class Program
    {
        private static ActorSystem SistemaStreamingFilmesActorSystem;

        static void Main(string[] args)
        {
            // Preciso rodar todos meus atores dentro de um ActorSystem
            SistemaStreamingFilmesActorSystem = ActorSystem.Create("SistemaStreamingFilmes");
            Console.WriteLine("[INFO] ActorSystem Criado ....");
            Console.WriteLine("");

            // Criar um ator do tipo ConsoleWriterActor usando ActorSystem  e Props: Don't worry ... veremos props mais adiante
            var consoleWriterActor = SistemaStreamingFilmesActorSystem.ActorOf(Props.Create(() => new ConsoleWriterActor()));            
            //var reprodutorStreamingActor = SistemaStreamingFilmesActorSystem.ActorOf(Props.Create(() => new ReprodutorStreamingActor(consoleWriterActor)));

            // Mandar uma mensagem para o ator
            //reprodutorStreamingActor.Tell(new ReprodutorStreamingActor.ReproduzirFilmeMensagem("Avengers", "1203"));

            // Não deixar a thread principal sair enquanto o Actor System não encerrar
            SistemaStreamingFilmesActorSystem.AwaitTermination();
        }
    }
}
