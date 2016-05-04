using System;

namespace DesignPatterns.AbstractFactory.Pepsi
{
    public class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}