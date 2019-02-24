namespace DesignPatterns.AbstractFactory.Vehicles.Transmissions
{
    class AutomaticTransmission : ITransmission
    {
        public string ShiftDown()
        {
            return "Shifting down automatically";
        }

        public string ShiftUp()
        {
            return "Shifting up automatically";
        }
    }
}
