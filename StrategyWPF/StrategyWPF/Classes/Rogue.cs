using StrategyWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace StrategyWPF.Classes
{
    public class Rogue : Unit
    {
        public Rogue(int health, int maxHealth, int mana, int maxMana) :
            base ("Rogue", health, maxHealth, mana, maxMana, 20, 65, 30, 250, 15, 70, 20, 80)
        {
            health = (int)Math.Round(1.5*Vitality + 0.5*Strength, 0);
            maxHealth = health;
            mana = (int)Math.Round(1.2*Intelligence, 0);
            maxMana = mana;
        }
    }
}
