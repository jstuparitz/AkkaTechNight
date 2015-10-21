using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace AkkaTechNight.ActorSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Akka.Actor.ActorSystem mActorSystem = Akka.Actor.ActorSystem.Create("MyActorSystem");
        }
    }
}
