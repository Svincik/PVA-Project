using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    public class Warrior : Entity
    {
        public Warrior(string name, EntityGender gender) :
            base()
        {
            Name = name;
            Gender = gender;
            //Adding stats
            _wisdom = rand.Next(1, 3);
            _strength = rand.Next(6, 10);
            _dexterity = rand.Next(1, 4);
            _health = rand.Next(100, 150); 
        }
    }
}
