using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GameDuel
{
    public class Battle
    {
        private  Character _firstWarrior;
        private  Character _secondWarrior;

        public Battle()
        {
            CharacterGenerator characterGenerator = new CharacterGenerator(2000);
            _firstWarrior = characterGenerator.CreateRandomCharacter();
            _secondWarrior = characterGenerator.CreateRandomCharacter();
        }
        

        public void Fight()
        {
            bool battleContinue = true;
            int turnToAttack = 0;
            while (battleContinue)
            {
                if (turnToAttack == 0)
                    _secondWarrior.LoseHealthPoints(_firstWarrior.GetWeapon());
                else
                {
                    _firstWarrior.LoseHealthPoints(_secondWarrior.GetWeapon());
                }
                Console.Clear();
                Console.WriteLine(_firstWarrior.ToString());
                Console.WriteLine(_secondWarrior.ToString());
                if (_firstWarrior.GetHealthPoints() == 0 || _secondWarrior.GetHealthPoints() == 0)
                    battleContinue = false;
                turnToAttack++;
                turnToAttack %= 2;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("The winner is :");
            if(_firstWarrior.GetHealthPoints() == 0)
                Console.WriteLine(_secondWarrior.ToString());
            else
            {
                Console.WriteLine(_firstWarrior.ToString());
            }
        }
        
        public override string ToString()
        {
            return $"{_firstWarrior}\n" +
                   $"{_secondWarrior}";
        }
    }
}