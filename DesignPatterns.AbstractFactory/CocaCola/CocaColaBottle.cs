using System;

namespace DesignPatterns.AbstractFactory.CocaCola
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}