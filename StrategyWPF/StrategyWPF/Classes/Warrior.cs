using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyWPF.Classes
{
    internal class Warrior : Unit
    {
        public Warrior(int health, int maxHealth, int mana, int maxMana) : 
            base ("Warrior", health, maxHealth, mana, maxMana, 30, 250, 15, 80, 10, 50, 25, 100)
        {
            health = 2*Vitality + 1*Strength;
            maxHealth = health;
            mana = Intelligence;
            maxMana = mana;
        }
    }
}
