using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace CollaboratorStudy.Monster
{
    internal class monster      // 몬스터 클래스입니다.
    {
        public string name { get; set; }
        public int age { get; set; }
        public int hp { get; set; }

        public monster()        // 몬스터 클래스의 생성자입니다.
        {
            name = "피카츄";
            age = 5;
            hp = 100;

        }
        
        public void pikapika()      
        {
            Console.WriteLine("피카츄 라이츄 파이리 꼬부기");
        }

        
    }
}
