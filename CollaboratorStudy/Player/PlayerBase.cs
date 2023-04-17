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
        /// <summary>
        /// 플레이어 일련번호
        /// </summary>
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 플레이어 이름
        /// </summary>
        string name;
        public string NAME{
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 플레이어 인벤토리
        /// (각 아이템 클래스, 해당 아이템 개수)의 딕셔너리로 구성
        /// </summary>
        Dictionary<Items, int> inventory;
        public Dictionary<Items, int> INVENTORY {
            get { return inventory; }
            set { inventory = value; }
        }

        /// <summary>
        /// 플레이어 파트너 포켓몬
        /// 크기 6의 배열로 구성
        /// </summary>
        MonsterClass[] partners;
        public MonsterClass[] PARTNERS {
            get { return partners; }
            set { partners = value; }
        }

        APPEARANCE appearnce;
        public APPEARANCE APPEARANCE
        {
            get { return appearnce; }
            set { appearnce = value; }
        }

        /// <summary>
        /// 플레이어 생성자 1
        /// 인벤토리, 파트너 포켓몬은 자동으로 초기화
        /// </summary>
        public PlayerBase()
        {
            INVENTORY = new Dictionary<Items, int>();
            partners = new MonsterClass[6];
        }

        /// <summary>
        /// 플레이어 생성자 2
        /// 인벤토리, 파트너 포켓몬은 자동으로 초기화
        /// </summary>
        /// <param name="id">플레이어 아이디</param>
        /// <param name="name">플레이어 이름</param>
        public PlayerBase(int id, string name, APPEARANCE appearnce) : base()
        {
            ID = id;
            NAME = name;
            APPEARANCE = appearnce;
        }
    }
}
