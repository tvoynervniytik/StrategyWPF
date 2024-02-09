using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyWPF.Classes
{
    internal class Wizard : Unit
    {
        public Wizard(int health, int maxHealth, int mana, int maxMana) : 
            base("Wizard", health, maxHealth, mana, maxMana, 15, 45, 20, 80, 35, 250, 15, 70)
        {
            health = (int)Math.Round(1.4*Vitality + 0.2*Strength, 0);
            maxHealth = health;
            mana = (int)Math.Round(1.5*Intelligence, 0);
            maxMana = mana;
        }
    }
}
