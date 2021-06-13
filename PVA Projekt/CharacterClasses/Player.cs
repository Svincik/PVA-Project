using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    class Player : Entity
    {
        public Player()
           : base()
        {

        }

        public Player(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }

        public Player(string name, EntityGender eGender, EntityClass eClass, int strength, int dexterity, int wisdom, int health)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            Strength = strength;
            Dexterity = dexterity;
            Wisdom = wisdom;
            Health = health;
        }
    }
}
