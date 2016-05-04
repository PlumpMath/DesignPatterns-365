using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.CocaCola;
using DesignPatterns.AbstractFactory.Pepsi;

namespace DesignPatterns.CallingApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();
            client = new Client(new PepsiFactory());
            client.Run();

            Console.ReadLine();
        }
    }
}
