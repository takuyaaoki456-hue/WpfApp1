using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApp1.Characters;

namespace WpfApp1
{
    public abstract class Effect
    {
        public int power;
        public abstract void OnApply(Character character);
        public abstract void OnTurnStart(Character character);
        public abstract void OnExpire(Character character);

    }
}
