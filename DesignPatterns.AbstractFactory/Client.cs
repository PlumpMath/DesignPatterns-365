namespace DesignPatterns.AbstractFactory
{
    public class Client
    {
        private readonly AbstractWater _water;
        private readonly AbstractBottle _bottle;

        public Client(AbstractFactory factory)
        {
            // Абстрагирование процессов инстанцирования.
            _water = factory.CreateWater();
            _bottle = factory.CreateBottle();
        }

        public void Run()
        {
            // Абстрагирование вариантов использования.
            _bottle.Interact(_water);
        }
    }
}