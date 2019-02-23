namespace DesignPatterns.Strategy.Transmission
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
