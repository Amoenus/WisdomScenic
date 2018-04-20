using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomScenic.Project.Domain.Entities;
using WisdomScenic.Project.DTO.Systems;

namespace WisdomScenic.Project.IBLL.Systems
{
    public interface IT_LogSettingService : IBaseService<T_LogSetting>
    {
        /// <summary>
        /// 查询操作日志
        /// </summary>
        /// <param name="param">DTO</param>
        /// <returns></returns>
        IList<T_LogSetting> FindLogSetting(LogSettingDTO param);
    }
}
