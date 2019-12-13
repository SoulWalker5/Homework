namespace ConsoleApp1
{
     class GetPart : Menu
    {
        protected Car car;
        public GetPart(Car car)
        {
            this.car = car;
        }
        protected override void InternalLogic()
        {
            car.GetPart();
        }
    }
}