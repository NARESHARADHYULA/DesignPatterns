using System;

namespace DesignPatterns
{
    /// <summary>
    /// Thread safe Lazy implementation of a singleton class
    /// untill we call lazy.value class is not instantiated
    /// lazy.value always takes of null values
    /// </summary>
    public sealed class Singleton
    {
        public static readonly Lazy<Singleton> _lazy = new(() => new Singleton());
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return _lazy.Value;
            }
        }
    }
}
