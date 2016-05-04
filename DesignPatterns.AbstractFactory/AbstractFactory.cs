namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
    }
}