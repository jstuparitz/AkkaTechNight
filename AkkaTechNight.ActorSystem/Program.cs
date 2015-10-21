namespace AkkaTechNight.ActorSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mActorSystem = Akka.Actor.ActorSystem.Create("MyActorSystem");
        }
    }
}