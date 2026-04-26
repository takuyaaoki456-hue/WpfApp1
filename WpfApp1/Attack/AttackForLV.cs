using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Characters;

namespace WpfApp1.Attack
{
    public class AttackForLV:Attack
    {
        public override void Apply(Character character, int power)
        {
            character.TakeLevelDamage(power);
        }
    }
}
