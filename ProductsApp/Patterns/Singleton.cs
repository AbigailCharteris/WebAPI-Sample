using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Patterns
{
    public sealed class Singleton
    {
        static readonly Singleton _instance = new Singleton();
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}