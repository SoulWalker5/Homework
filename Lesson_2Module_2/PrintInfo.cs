namespace ConsoleApp1
{
    internal class PrintInfo : Menu
    {
        protected Car car;

        public PrintInfo(Car car)
        {
            this.car = car;
        }
        protected override void InternalLogic()
        {
            car.PrintInfo();
        }
    }
}