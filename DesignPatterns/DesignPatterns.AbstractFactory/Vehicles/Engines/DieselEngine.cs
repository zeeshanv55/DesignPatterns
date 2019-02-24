namespace DesignPatterns.AbstractFactory.Vehicles.Engines
{
    class DieselEngine : IEngine
    {
        public string Start()
        {
            return $"Starting diesel engine";
        }

        public string Stop()
        {
            return $"Stopping diesel engine";
        }
    }
}
