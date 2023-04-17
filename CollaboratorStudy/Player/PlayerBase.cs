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

        Item.Item[] inventory;
        public Item.Item[] INVENTORY {
            get { return inventory; }
            set { inventory = value; }
        }

        monster[] partners;
        public monster[] PARTNERS {
            get { return partners; }
            set { partners = value; }
        }
    }
}
