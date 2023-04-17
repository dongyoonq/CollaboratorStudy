using System;
using System.Collections.Generic;
using System.Text;

namespace CollaboratorStudy.Monster
{
    internal class Sudaeng : MonsterClass
    {
        public Sudaeng()
        {
            name = "수댕이";
        }

        public new void Move()                  // 이동 함수
        {
            Console.WriteLine(name + "가 뒤뚱거리며 이동합니다.");
        }
        public override void TakeDamage()       // 피격함수
        {
            base.TakeDamage();
            Console.WriteLine(name + "가 물방울을 튀깁니다.");
        }
    }
}
