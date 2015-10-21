using System;
using Akka.Actor;

namespace AkkaTechNight.Actors
{
    public class Driver : ReceiveActor
    {
        public Driver(Guid guid)
        {
            DriverId = guid;
        }

        public Guid DriverId { get; private set; }
    }
}