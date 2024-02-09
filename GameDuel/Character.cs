using System;

namespace GameDuel
{
    public class Character
    {
        private string _name;
        private int _healthPoints;
        private Weapon _weapon;
        private Armor _armor;
        
        public Character(string name, int healthPoints, Weapon weapon, Armor armor)
        {
            _name = char.ToUpper(name[0]) + name.ToLower().Substring(1);
            _healthPoints = healthPoints;
            _weapon = weapon;
            _armor = armor;
        }

        public string SetName(string name)
        {
            _name = char.ToUpper(name[0]) + name.ToLower().Substring(1);
            return _name;
        }
        public string GetName()
        {
            return _name;
        }
        public int SetHealthPoints(int healthPoints)
        {
            _healthPoints = healthPoints;
            return _healthPoints;
        }
        public int GetHealthPoints()
        {
            return _healthPoints;
        }
        public Weapon SetWeapon(Weapon weapon)
        {
            _weapon = weapon;
            return _weapon;
        }
        public Weapon GetWeapon()
        {
            return _weapon;
        }
        public Armor SetArmor(Armor armor)
        {
            _armor = armor;
            return _armor;
        }
        public Armor GetArmor()
        {
            return _armor;
        }

        public void LoseHealthPoints(Weapon weapon)
        {
            int lose = weapon.GetAttackValue() - _armor.GetProtectionValue();
            if (lose < 0)
                lose = 1;
            if (_healthPoints - lose < 0)
                _healthPoints = 0;
            else
            {
                _healthPoints -= lose;
            }
        }
        public override string ToString()
        {
            return $"{_name} => " +
                   $"❤️ {_healthPoints} | " +
                   $"⚔️ {_weapon.ToString()} | " +
                   $"🛡️ {_armor.ToString()}";
        }
    }
}