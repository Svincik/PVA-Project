using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_Projekt.CharacterClasses
{
    class NPC: Entity
    {
        public NPC() 
            : base() 
        {

        }

        public NPC(string name, EntityGender eGender)
            : base()
        {
            Name = name;
            Gender = eGender;
        }
    }
}
