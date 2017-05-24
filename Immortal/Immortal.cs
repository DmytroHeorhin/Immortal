using System;

namespace Immortal
{
    public class Immortal
    {
        private int _finalizationCount;
        ~Immortal()
        {
            Console.WriteLine("Immortal object is having it's finalizer called {0}th time", ++_finalizationCount);
            GC.ReRegisterForFinalize(this);
        }
    }
}
