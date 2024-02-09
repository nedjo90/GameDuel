namespace GameDuel
{
    public class Armor
    {
        private string _name;
        private int _protectionValue;

        public string GetName()
        {
            return _name;
        }

        public string SetName(string name, int age)
        {
            this._name = char.ToUpper(name[0]) + name.ToLower().Substring(1);
            return _name;
        }

        public int GetProtectionValue()
        {
            return _protectionValue;
        }
        
        public int SetProtectionValue(int protectionValue)
        {
            _protectionValue = protectionValue;
            return _protectionValue;
        }
        
        public Armor(string name, int protectionValue)
        {
            _name = char.ToUpper(name[0]) + name.ToLower().Substring(1);
            _protectionValue = protectionValue;
        }

        public override string ToString()
        {
            return $"{_name}: {_protectionValue}";
        }
    }
}