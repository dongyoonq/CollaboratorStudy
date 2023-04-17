using System;
using System.Collections.Generic;
using System.Text;

namespace CollaboratorStudy.Monster
{
    internal class Pikachu : MonsterClass       // MonsterClass를 계승한 자식 클래스 Pikachu
    {
        public Pikachu()
        {
            name = "피카츄";
        }

        public new void Move()                  // 이동 함수
        {
            Console.WriteLine(name + "가 폴짝거리며 이동합니다.");
        }
        public override void TakeDamage()       // 피격함수
        {
            base.TakeDamage();
            Console.WriteLine(name + "가 스파크를 튀깁니다.");
        }
    }
}
