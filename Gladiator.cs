using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmass_2023_Arena
{
    public class Gladiator
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public Gladiator(string name, int strength, int health)
        {
            Name = name;
            Strength = strength;
            Health = health;
        }
        public Gladiator() { }
        public override string ToString()
        {
            return $"Name => [{Name}] Strength => [{Strength}] Health => [{Health}]";
        }
    }
}
