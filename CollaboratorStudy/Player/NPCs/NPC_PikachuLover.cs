using CollaboratorStudy.Monster;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CollaboratorStudy.Player.NPCs
{
    internal class NPC_PikachuLover : PlayerBase
    {

        public NPC_PikachuLover() : base()
        {
            ID = 2;
            NAME = "피카츄 애호가";
            PARTNERS[0] = new MonsterClass();
            PARTNERS[1] = new MonsterClass();
            PARTNERS[2] = new MonsterClass();
            PARTNERS[3] = new MonsterClass();
            PARTNERS[4] = new MonsterClass();
            PARTNERS[5] = new MonsterClass();
        }
    }
}
