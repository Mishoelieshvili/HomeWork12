using System;
using System.Numerics;
using static Task2.MainActor;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            IActor actor = new Actor();
            IActor proxy = new ActorProxy(actor);

            Console.WriteLine("Main actor is performing.");
            actor.Act();

            Console.WriteLine();

            Console.WriteLine("Proxy is performing.");
            proxy.Act();

            Console.ReadKey();
        }
    }
}
