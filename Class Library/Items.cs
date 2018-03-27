using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    class Items
    {
        public int id;
        public string name;

        public Items(int Iid, string Iname)
        {
            id = Iid;
            name = Iname;
        }

    }
    class Consumables : Items
    {
        public int amount;
        public bool stackable;
        public bool underaffect;
        public int stackaffect;

        public Consumables(int Iid, string Iname, bool Istackable) : base (Iid, Iname)
        {
            amount = 0;
            stackable = Istackable;
            underaffect = false;
            stackaffect = 0;
        }

    }
    class Special : Items
    {
        public bool own;

        public Special(int Iid, string Iname) : base(Iid, Iname)
        {
            own = false;
        }

    }
    class Log : Special
    {
        public bool listento;

        public Log(int Iid, string Iname) : base(Iid, Iname)
        {
            own = false;
            listento = false;
        }

    }
}
