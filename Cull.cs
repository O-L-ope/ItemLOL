using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisująca konkretny rodzaj itemu w sklepie
     */
    public class Cull : Item
    {
        //deprecated???
        //public int bonusHP = 150;
        public Cull()
        {
            //ustalamy nazwe itemu
            name = "Cull";
            // jego cene
            price = 450;
            //i atrybuty
            AddStat(Stat.HP, 0);
            AddStat(Stat.HOH, 3);
            AddStat(Stat.AD, 7);
        }
    }
}
