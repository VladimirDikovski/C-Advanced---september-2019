
namespace DefiningClasses
{
   public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine()
        {

        }
        public Engine(int engineSpeed ,int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
}
}
