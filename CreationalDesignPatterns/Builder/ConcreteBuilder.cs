namespace Builder
{
    public class ConcreteBuilder : Builder
    {
        private Car _car;

        public ConcreteBuilder()
        {
            _car = new Car();
        }

        public override void BuildSection1()
        {
            _car.Add("Engine");
        }

        public override void BuildSection2()
        {
            _car.Add("Gearbox");
        }

        public override Car GetCar()
        {
            return _car;
        }
    }
}