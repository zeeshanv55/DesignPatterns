namespace DesignPatterns.AbstractFactory.Vehicles
{
    interface IVehicle
    {
        string Move();

        string Turn();

        string Start();

        string Stop();

        string ShiftUp();

        string ShiftDown();
    }
}
