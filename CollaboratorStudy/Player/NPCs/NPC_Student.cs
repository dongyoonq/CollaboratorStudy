using CollaboratorStudy.Monster;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollaboratorStudy.Player.NPCs
{
    internal class NPC_Student : PlayerBase
    {
        public NPC_Student() : base()
        {
            ID = 1;
            NAME = "학생";
            PARTNERS[0] = new MonsterClass();
        }
    }
}
