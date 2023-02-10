using System;

namespace Singleton
{

    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = new ChocolateBoiler();
            boiler.fill();
            boiler.boil();
            boiler.drain();
        }
    }
}
