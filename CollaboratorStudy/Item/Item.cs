using CollaboratorStudy.Monster;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollaboratorStudy.Item
{
    /// <summary>
    /// 아이템의 종류가 들어있습니다.
    /// </summary>
    internal class Items : MonsterClass
    {
        public string name;
        public int price;
        public int money;
        public string dropIT;

        // 아이템 큰구슬을 생성
        public void BigBead()
        {
            this.name = "큰구슬";
            this.price = 3000;
        }
        // 아이템 작은구슬을 생성
        public void SmallBead()
        {
            this.name = "작은구슬";
            this.price = 1500;
        }
        // 랜덤아이템 드랍
        public void RandomDropItem()
        {
            Random randomDrop = new Random();
            randomDrop.Next(money, name.Length);
        }
        // 플레이어가 아이템을 사용할 수 있게 만들었습니다.
        public virtual void Use() { }

        // 아이템에 돈을 만들었습니다.
        public void DropMoney()
        {
            Random randomMoney = new Random();
            this.money += randomMoney.Next(1, 999999);
        }
        
        // 드랍하는 아이템
        public void DropItems()
        {
            Random randomItems = new Random();
            RandomDropItem();
        }
    }
}
