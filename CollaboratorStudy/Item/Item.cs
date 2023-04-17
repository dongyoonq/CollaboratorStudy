﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollaboratorStudy.Item
{
    /// <summary>
    /// 아이템의 종류가 들어있습니다.
    /// </summary>
    internal class Items
    {
        public string name;
        public int price;
        public int money;

        // 아이템을 야무지게 만들었따
        public void BigBead()
        {
            this.name = ("큰구슬");
            this.price = (3000);
        }
        // 플레이어가 아이템을 사용할 수 있게 만들었습니다.
        public virtual void Use() { }

        // 아이템에 돈을 만들었습니다.
        public void DropMoney()
        {
            Random random = new Random();
            this.money += random.Next(1, 999999);
        }
        
    }
}
