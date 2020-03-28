using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
      public  static void Main(string[] args)
        {
            var newPokemon = new Pokemon();
            var ListOftrainer = new Dictionary<string, Trainer>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if(input== "Tournament")
                {
                    break;
                }

                string[] splitedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string treinerName = splitedInput[0];
                string pokemonName = splitedInput[1];
                string pokomenElement = splitedInput[2];
                int pokomonHealth = int.Parse(splitedInput[3]);
                newPokemon = new Pokemon(pokemonName, pokomenElement, pokomonHealth);
                var newTrainer = new Trainer();
                newTrainer.Name = treinerName;
                newTrainer.Pokemons.Add(newPokemon);
                if (!ListOftrainer.ContainsKey(newTrainer.Name))
                {
                    ListOftrainer[newTrainer.Name] = newTrainer;
                }
                else
                {
                    ListOftrainer[newTrainer.Name].Pokemons.Add(newPokemon);
                }
          
            }

            while (true)
            {
                string elemental = Console.ReadLine();
                if (elemental == "End")
                {
                    break;
                }

                foreach (var item in ListOftrainer.Values)
                {
                    if (item.Pokemons.Any(x=>x.Element==elemental))
                    {                     
                            item.NumberOfBadget += 1;                    
                    }
                    else
                    {
                        foreach (var helath in item.Pokemons )
                        {
                            helath.Health -= 10;
                        }   
                    }
                    if(item.Pokemons.Any(x=>x.Health<=0))
                    {
                        for (int i = 0; i <item.Pokemons.Count; i++)
                        {
                            item.Pokemons.Remove(item.Pokemons[i]);
                        }
                    }
                }
              


            }
              foreach (var item in ListOftrainer)
                {
                    Console.WriteLine($"{item.Key} {item.Value.NumberOfBadget} {item.Value.Pokemons.Count}");
                }

        }
    }
}
