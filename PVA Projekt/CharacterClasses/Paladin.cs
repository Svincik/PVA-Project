using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    public class Paladin : Entity
    {
        public Paladin(string name, EntityGender gender) :
            base()
        {
            Name = name;
            Gender = gender;
            //Adding stats
            _wisdom = rand.Next(2, 4);
            _strength = rand.Next(6, 8);
            _dexterity = rand.Next(3, 6);
            _health = rand.Next(90, 130);
        }
    }
}
