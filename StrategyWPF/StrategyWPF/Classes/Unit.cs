using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyWPF.Classes
{
    public class Unit
    {
        private string _name;
        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _vitality;
        private int _health;
        private int _maxHealth;
        private int _mana;
        private int _maxMana;
        //private int _armor;
        //private int _defense;
        //private int _chance;
        //private int _damage;
        //private int _mdamage;
        //private int _crtdamage;
        public int Health { get => _health; set => _health = value; }
        public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Mana { get => _mana; set => _mana = value; }
        public int MaxMana { get => _maxMana; set => _maxMana = value; }
        //сила
        public int Strength { get => _strength; set => _strength = value; }
        //ловкость
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        //интеллект
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        //жизнеспособность
        public int Vitality { get => _vitality; set => _vitality = value; }
        private int _maxstrength;
        private int _maxdexterity;
        private int _maxintelligence;
        private int _maxvitality;
        //сила
        public int MaxStrength { get => _maxstrength; set => _maxstrength = value; }
        //ловкость
        public int MaxDexterity { get => _maxdexterity; set => _maxdexterity = value; }
        //интеллект
        public int MaxIntelligence { get => _maxintelligence; set => _maxintelligence = value; }
        //жизнеспособность
        public int MaxVitality { get => _maxvitality; set => _maxvitality = value; }
        //имя
        public string Name { get => _name; set => _name = value; }
        public Unit(string name, int Health, int MaxHealth, int Mana, int MaxMana, int strength, int maxstrength, 
            int dexterity, int maxdexterity,
            int intelligence, int maxintelligence, int vitality, 
             int maxvitality) 
        {
            _health = Health;
            _maxHealth = MaxHealth;
            _mana = Mana;
            _maxMana = MaxMana;
            _name = name;
            _strength = strength;
            _intelligence = intelligence;
            _vitality = vitality;
            _dexterity = dexterity;
            _maxdexterity = maxstrength;
            _maxintelligence = maxintelligence;
            _maxvitality = vitality;
            _maxstrength = maxstrength;
        }
    }
}
