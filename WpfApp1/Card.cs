using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class Card
    {
        public string Name {  get; set; }
        public int Attack {  get; set; }
        public int Cost {  get; set; }

        public List<Effect> Effects {  get; set; }

        public Card(string name, int attack, int cost, List<Effect> effects)
        {
            Name = name;
            Attack = attack;
            Cost = cost;
            Effects = new List<Effect>();
        }
    }
}
