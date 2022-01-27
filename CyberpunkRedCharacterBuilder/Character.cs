using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkRedCharacterBuilder
{
    public class Character
    {

        public int INT, REF, DEX, TECH, COOL, WILL, LUCK_Max, LUCK, MOVE, BODY, EMP;
        public string name, role;
        public int ip;
        public Character(string _name, int _INT, int _REF, int _DEX, int _TECH, int _COOL, int _WILL, int _LUCK_Max, int _MOVE, int _BODY, int _EMP, string _role, int _ip)
        {
            name = _name;

            INT = _INT;
            REF = _REF;
            DEX = _DEX;
            TECH = _TECH;
            COOL = _COOL;
            WILL = _WILL;
            LUCK_Max = _LUCK_Max;
            MOVE = _MOVE;
            BODY = _BODY;
            EMP = _EMP;

            role = _role;
            ip = _ip;

        }
    }
}
