using System;

namespace Immortal
{
    internal class Program
    {
        private static Immortal _immortalObject;

        static void Main(string[] args)
        {
            Allocate();
            Nullify();
            for (var i = 1; i < 10000; i++)
            {
                var largeObject = new Large(i);
            }
        }

        private static void Allocate()
        {
            _immortalObject = new Immortal();
        }

        private static void Nullify()
        {
            _immortalObject = null;
        }
    }
}
