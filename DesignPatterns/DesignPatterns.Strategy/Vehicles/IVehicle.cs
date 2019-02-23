namespace DesignPatterns.Strategy.Vehicles
{
    using Transmission;

    interface IVehicle
    {
        string Move();

        string Turn();

        string ShiftUp();

        string ShiftDown();

        void SetTransmissionType(ITransmission transmission);
    }
}
