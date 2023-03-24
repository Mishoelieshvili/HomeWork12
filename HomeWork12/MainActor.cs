using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MainActor
    {

        public interface IActor
        {
            void Act();
        }
        public class Actor : IActor
        {
            public void Act()
            {
                Console.WriteLine("Actor is acting in a simple scene.");
            }
        }

        public class Stuntman : IActor
        {
            public void Act()
            {
                Console.WriteLine("Stuntman is performing a dangerous action in a scene.");
            }
        }

        public class ActorProxy : IActor
        {
            private readonly IActor _mainActor;
            private readonly Stuntman _stuntman = new Stuntman();

            public ActorProxy(IActor mainActor)
            {
                _mainActor = mainActor;
            }

            public void Act()
            {
                if (IsDifficultScene())
                {
                    _stuntman.Act();
                }
                else
                {
                    _mainActor.Act();
                }
            }

            private bool IsDifficultScene()
            {
                return true;
            }
        }




    }
}
