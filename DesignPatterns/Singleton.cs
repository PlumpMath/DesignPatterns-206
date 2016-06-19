using System;
namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton ();

        static Singleton (){ }

        private Singleton () { }

        public static Singleton Instance => instance;
    }
}

