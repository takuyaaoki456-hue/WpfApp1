using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Attack
{
    public abstract class Attack
    {
        public abstract void Apply(Character character, int power);
    }
}
