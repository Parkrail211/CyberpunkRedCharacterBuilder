using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkRedCharacterBuilder
{


   public class Skill
    {
        public int skillMod;
        public string name, statName;

        public Skill(string _name, string _statName, int _skillMod)
        {
            name = _name;

            skillMod = _skillMod;

            statName = _statName;
        }
    }


}
