using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    public class Cleric : Entity
    {
        public Cleric(string name, EntityGender gender) :
            base()
        {
            Name = name;
            Gender = gender;
            //Adding stats
            _wisdom = rand.Next(5, 8);
            _strength = rand.Next(4, 6);
            _dexterity = rand.Next(2, 5);
            _health = rand.Next(90, 130);
        }
    }
}
