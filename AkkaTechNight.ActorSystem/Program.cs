using System;
using System.Collections.Generic;
using Akka.Actor;
using AkkaTechNight.Actors;

namespace AkkaTechNight.ActorSystem
{
    internal class Program
    {
        private static Akka.Actor.ActorSystem MyActorSystem;
        private static void Main(string[] args)
        {
            MyActorSystem = Akka.Actor.ActorSystem.Create("MyActorSystem");
            saList<IActorRef> drivers = CreateDrivers();

            MyActorSystem.AwaitTermination();
        }

        private static List<IActorRef> CreateDrivers()
        {
            List<IActorRef> list = new List<IActorRef>();
            int x = 0;
            while (x < 300000)
            {
                list.Add(MyActorSystem.ActorOf(Props.Create(() => new Driver(Guid.NewGuid()))));
                x++;
            }
            return list;
        } 
    }
}