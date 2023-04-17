using System;
using System.Collections.Generic;
using System.Text;

namespace CollaboratorStudy.Player
{
    /// <summary>
    /// 캐릭터 외형에 대한 열거형
    /// </summary>
    [Flags] internal enum APPEARANCE { 
        // 성별
        BOY = 0b_0000_0000_0000_0001,
        GIRL = 0b_0000_0000_0000_0010,

        // 헤어
        NONE = 0b_0000_0000_0000_0100,
        SHORT = 0b_0000_0000_0000_1000,
        MIDDLE = 0b_0000_0000_0001_0000,
        LONG = 0b_0000_0000_0010_0000,

        // 얼굴
        COOL = 0b_0000_0000_0100_0000,
        PRETTY = 0b_0000_0000_1000_0000,
        CUTE = 0b_0000_0001_0000_0000,

        // 체형
        THIN = 0b_0000_0010_0000_0000,
        NORMAL = 0b_0000_0100_0000_0000,
        FAT = 0b_0000_1000_0000_0000,
        MUSCULAR = 0b_0001_0000_0000_0000,

        // 피부
        WHITE = 0b_0010_0000_0000_0000,
        ORANGE = 0b_0100_0000_0000_0000,
        BLACK = 0b_1000_0000_0000_0000
    }
}
