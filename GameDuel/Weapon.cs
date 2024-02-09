namespace GameDuel
{
    public class Weapon
    {
        private string _name;
        private int _attackValue;

        public string GetName()
        {
            return _name;
        }
        
        public string SetName(string name)
        {
            _name = char.ToUpper(name[0]) + name.ToLower().Substring(1);
            return _name;
        }
        
        public int GetAttackValue()
        {
            return _attackValue;
        }
        
        public int SetAttackValue(int attackValue)
        {
            _attackValue = attackValue;
            return _attackValue;
        }
        
        public Weapon(string name, int attackValue)
        {
            _name = char.ToUpper(name[0]) + name.ToLower().Substring(1);
            _attackValue = attackValue;
        }

        public override string ToString()
        {
            return $"{_name}: {_attackValue}";
        }
    }
}