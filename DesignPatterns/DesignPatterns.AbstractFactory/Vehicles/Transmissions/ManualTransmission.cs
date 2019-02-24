namespace DesignPatterns.AbstractFactory.Vehicles.Transmissions
{
    class ManualTransmission : ITransmission
    {
        public string ShiftDown()
        {
            return "Shifting down manually";
        }

        public string ShiftUp()
        {
            return "Shifting up manually";
        }
    }
}
