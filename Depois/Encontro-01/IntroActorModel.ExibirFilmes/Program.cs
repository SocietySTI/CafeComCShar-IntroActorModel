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
            SistemaStreamingFilmesActorSystem = ActorSystem.Create("SitemaStreamingFilmes");
            Console.WriteLine("[INFO] ActorSystem Criado ....");
            Console.WriteLine("");

            // Criar um atores usando ActorSystem  e Props: Don't worry ... veremos props mais adiante
            var consoleWriterActor = SistemaStreamingFilmesActorSystem.ActorOf(Props.Create(() => new ConsoleWriterActor()));
            var reprodutorStreamingActor = SistemaStreamingFilmesActorSystem.ActorOf(Props.Create(() => new ReprodutorStreamingActor(consoleWriterActor)));
            var coordinatorActor = SistemaStreamingFilmesActorSystem.ActorOf(Props.Create(() => new ConsoleCoordinatorActor(consoleWriterActor)));

            // Mandar uma mensagem para o ator coordenado iniciar o sistema
            coordinatorActor.Tell("iniciar");

            // Não deixar a thread principal sair enquanto o Actor System não encerrar
            SistemaStreamingFilmesActorSystem.AwaitTermination();
        }
    }
}
