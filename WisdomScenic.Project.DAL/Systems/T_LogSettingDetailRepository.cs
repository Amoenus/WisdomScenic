using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomScenic.Project.Domain.Entities;
using WisdomScenic.Project.IDAL.Systems;

namespace WisdomScenic.Project.DAL.Systems
{
    /// <summary>
    /// 作用：操作日志详情
    /// 时间：20148-03-13
    /// 作者：沈鹏飞
    /// </summary>
    public class T_LogSettingDetailRepository : BaseRepository<T_LogSettingDetail>, IT_LogSettingDetailRepository
    {
    }
}
