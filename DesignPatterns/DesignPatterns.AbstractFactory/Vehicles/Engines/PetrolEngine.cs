namespace DesignPatterns.AbstractFactory.Vehicles.Engines
{
    class PetrolEngine : IEngine
    {
        public string Start()
        {
            return $"Starting petrol engine";
        }

        public string Stop()
        {
            return $"Stopping petrol engine";
        }
    }
}
