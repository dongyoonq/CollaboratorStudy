using System;
using System.Collections.Generic;
using System.Text;
using CollaboratorStudy.Item;
using CollaboratorStudy.Monster;

namespace CollaboratorStudy.Player
{
    /// <summary>
    /// 플레이어 데이터
    /// </summary>
    internal class PlayerBase
    {
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string name;
        public string NAME{
            get { return name; }
            set { name = value; }
        }

        Dictionary<Items, int> inventory;
        public Dictionary<Items, int> INVENTORY {
            get { return inventory; }
            set { inventory = value; }
        }

        MonsterClass[] partners;
        public MonsterClass[] PARTNERS {
            get { return partners; }
            set { partners = value; }
        }

        public PlayerBase(int id, string name)
        {
            ID = id;
            NAME = name;
            INVENTORY = new Dictionary<Items, int>();
            partners = new MonsterClass[6];
        }
    }
}
