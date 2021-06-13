using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    public class Mage : Entity
    {
        public Mage() :
            base()
        {

        }
        public Mage(string name, EntityGender gender) :
            base()
        {
            Name = name;
            Gender = gender;
            //Adding stats
            _wisdom = rand.Next(6, 9);
            _strength = rand.Next(1, 3);
            _dexterity = rand.Next(2, 5);
            _health = rand.Next(70, 100);

        }
    }
}
