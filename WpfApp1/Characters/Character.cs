using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Characters
{
    public enum Team
    {
        Ally,
        Enemy,
        Anomaly
    }
    public class Character
    {
        string Name { get; set; }
        int HP { get; set; }
        int MP { get; set; }
        int LV { get; set; }
        int Atk { get; set; }
        Team team;

        List<Effect> Effects = new List<Effect>();

        //試しに打ち込んでみる
        public Character(string name, int hp, int mp, int lv, int atk)
        {
            Name = name;
            HP = hp;
            MP = mp;
            LV = lv;
            Atk = atk;
        }


        //ダメージ計算用
        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP < 0) HP = 0;
        }

        public void TakeMPDamage(int damage)
        {
            MP -= damage;
            if (MP < 0) MP = 0;
        }

        public void TakeLevelDamage(int damege)
        {
            LV -= damege;
            if(LV < 1) LV = 1;
        }

        //バフ用
        public void AddEffect(Effect effect)
        {
            Effects.Add(effect);
            effect.OnApply(this);
        }
    }
}
