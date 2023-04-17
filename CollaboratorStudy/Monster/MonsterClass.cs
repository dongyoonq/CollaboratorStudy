using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace CollaboratorStudy.Monster
{
    internal class MonsterClass      // 몬스터 클래스입니다.
    {
        public string name { get; set; }
        public int age { get; set; }
        public int hp { get; set; }

        public MonsterClass()        // 몬스터 클래스의 생성자입니다.
        {
            name = "포켓몬";
            age = 5;
            hp = 100;

        }

        public void Move()          // 이동 함수 추가
        {
            Console.WriteLine(name + "이 움직입니다.");
        }

        public void Hit()       // 공격 함수입니다.
        {
            int damage = 20;
            hp -= damage;
        } 
        
    }
}
