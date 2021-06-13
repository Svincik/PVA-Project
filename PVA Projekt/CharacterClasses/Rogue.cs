using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    public class Rogue : Entity
    {
        public Rogue(string name, EntityGender gender) :
            base()
        {
            Name = name;
            Gender = gender;
            //Adding stats
            _wisdom = rand.Next(2, 5);
            _strength = rand.Next(4, 7);
            _dexterity = rand.Next(6, 9);
            _health = rand.Next(60, 90);
        }
    }
}
