namespace ConsoleApp1
{
    internal class GetStatus : Menu
    {
        private Car car;

        public GetStatus(Car car)
        {
            this.car = car;
        }
        protected override void InternalLogic()
        {
            car.GetStatus();
        }
    }
}