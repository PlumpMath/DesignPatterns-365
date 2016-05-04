namespace DesignPatterns.AbstractFactory.Pepsi
{
    public class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}