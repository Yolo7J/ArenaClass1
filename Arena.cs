using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Christmass_2023_Arena
{
    public class Arena
    {
        
        private Collection<Gladiator> gladiators;
        public string City { get; set; }
        public int Capacity { get; set; }
        public Arena(string city, int capacity)
        {
            gladiators = new Collection<Gladiator>();
            City = city;
            Capacity = capacity;
        }
        public int GladiatorCount()
        {
            return gladiators.Count;
        }
        public string AddGladiator(Gladiator gladiator)
        {
            bool alreadyPresent = false;
            foreach (Gladiator g in gladiators)
            {
                if (g.Name == gladiator.Name)
                {
                    gladiators.Remove(g);
                    alreadyPresent = true;
                    break;
                }
            }
            if (gladiators.Count > Capacity)
            {
                return"The arena is full";
            }
            else if(alreadyPresent == true)
            {
                return$"{gladiator.Name} is already enlisted";
            }
            else
            {
                gladiators.Add(gladiator);
                return $"{gladiator.Name} successfully enlisted in the arena";
            }
        }
        public bool RemoveGladiator(string name)
        {
            bool removed = false;
            foreach(Gladiator g in gladiators)
            {
                if(g.Name == name)
                {
                    gladiators.Remove(g);
                    removed = true;
                    break;
                }
            }
            if(removed == true) { return true;}
            else { return false;}
        }
        public Gladiator GetStrongestGladiator()
        {
            return gladiators.OrderByDescending(n => n.Strength).First();
        }
        public string Battle(string firstname, string secondname)
        {
            Gladiator firstFighter = new Gladiator();
            Gladiator secondFighter = new Gladiator();
            int n1 = 0;
            int n2 = 0;
            for (int i = 0; i < gladiators.Count; i++)
            {
                if (gladiators[i].Name == firstname)
                {
                    n1 = i;
                    firstFighter = gladiators[i];
                }
                else if (gladiators[i].Name == secondname)
                {
                    n2 = i;
                    secondFighter = gladiators[i];
                }
            }
            
            string result = string.Empty;
            if (firstFighter.Strength > secondFighter.Strength)
            {
                result = $"The winner is {firstFighter.Name}.";
                gladiators[n2].Health -= gladiators[n1].Strength;
                if (gladiators[n2].Health <= 0)
                {
                    gladiators.RemoveAt(n2);
                    result += $" {secondFighter.Name} died in the arena.";
                }
                return result;
            }
            else if(firstFighter.Strength < secondFighter.Strength)
            {
                result = $"The winner is {secondFighter.Name}.";
                gladiators[n1].Health -= gladiators[n2].Strength;
                if (gladiators[n1].Health <= 0)
                {
                    gladiators.RemoveAt(n1);
                    result += $" {firstFighter.Name} died in the arena.";
                }
                return result;
            }
            else
            {
                return "There is no winner.";
            }
        }
        public string ArenaInfo()
        {
            string result = string.Empty;
            return $"Gladiators enlisted in the grand arena of {City}: \n{string.Join("\n",gladiators)}";
        }
    }
}