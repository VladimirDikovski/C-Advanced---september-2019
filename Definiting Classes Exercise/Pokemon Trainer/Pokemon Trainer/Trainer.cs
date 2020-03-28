using System.Collections.Generic;
namespace DefiningClasses
{
   public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadget { get; set; }
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public Trainer()
        {

        }
      
    }
}
