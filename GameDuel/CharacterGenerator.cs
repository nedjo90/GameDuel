using System;
using System.Collections.Generic;

namespace GameDuel
{
    public class CharacterGenerator
    {
        private List<string> _listOfNames;
        private List<Armor> _listOfArmor;
        private List<Weapon> _listOfWeapon;
        private int _healthPoints;

        public CharacterGenerator(int healthPoints)
        {
            _listOfNames = CreateListOfNames();
            _listOfArmor = CreateListOfArmors();
            _listOfWeapon = CreateListOfWeapon();
            _healthPoints = healthPoints;
        }
        
        public Character CreateRandomCharacter()
        {
            string randomName = _listOfNames[GenerateRandomNumber(_listOfNames.Count)];
            Weapon randomWeapon = _listOfWeapon[GenerateRandomNumber(_listOfWeapon.Count)];
            Armor randomArmor = _listOfArmor[GenerateRandomNumber(_listOfArmor.Count)];
            Character character = new Character(randomName, _healthPoints, randomWeapon, randomArmor);
            return character;
        }
        
        private List<string> CreateListOfNames()
        {
            List<string> listOfNames = new List<string>();
            listOfNames.Add("richard coeur de lion");
            listOfNames.Add("charlemagne");
            listOfNames.Add("saladin");
            listOfNames.Add("attila");
            listOfNames.Add("ghengiz Khan");
            listOfNames.Add("mehmet the conqueror");
            listOfNames.Add("godefroy de bouillon");
            listOfNames.Add("jeanne d'arc");
            listOfNames.Add("tamerlan");
            listOfNames.Add("ragnar");

            return listOfNames;
        }
        
        private List<Armor> CreateListOfArmors()
        {
            List<Armor> listOfArmors = new List<Armor>();
            
            listOfArmors.Add(new Armor("leather armour", 100));
            listOfArmors.Add(new Armor("gantlet", 150));
            listOfArmors.Add(new Armor("round shield",200));
            listOfArmors.Add(new Armor("helmet",250));
            listOfArmors.Add(new Armor("chain-mail",300));
            listOfArmors.Add(new Armor("kite shield",350));
            listOfArmors.Add(new Armor("close helmet",400));
            listOfArmors.Add(new Armor("breast armor",450));
            listOfArmors.Add(new Armor("plate armor",500));
            listOfArmors.Add(new Armor("roman shield",550));
            
            return listOfArmors;
        }
        
        private List<Weapon> CreateListOfWeapon()
        {
            List<Weapon> listOfWeapons = new List<Weapon>();
            
            listOfWeapons.Add(new Weapon("knife", 100));
            listOfWeapons.Add(new Weapon("dagger", 150));
            listOfWeapons.Add(new Weapon("bow", 200));
            listOfWeapons.Add(new Weapon("sword", 250));
            listOfWeapons.Add(new Weapon("katana", 300));
            listOfWeapons.Add(new Weapon("axe", 350));
            listOfWeapons.Add(new Weapon("spear", 400));
            listOfWeapons.Add(new Weapon("pike", 500));
            return listOfWeapons;
        }
        
        private int GenerateRandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(0, max);
        }
    }
}