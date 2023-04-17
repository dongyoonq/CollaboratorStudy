using System;
using System.Collections.Generic;
using System.Text;
using CollaboratorStudy.Item;

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
    }
}
