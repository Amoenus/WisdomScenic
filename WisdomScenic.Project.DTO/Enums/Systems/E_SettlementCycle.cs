using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomScenic.Project.DTO.Enums
{
    public enum E_SettlementCycle
    {
        [EnumDisplayName("月结")]
        Month = 1,
        [EnumDisplayName("周结")]
        Week = 2,
        [EnumDisplayName("日结")]
        Day = 3,
    }
}
