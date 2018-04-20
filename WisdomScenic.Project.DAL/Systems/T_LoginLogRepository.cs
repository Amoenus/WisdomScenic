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
    /// 登录日志
    /// </summary>
    public class T_LoginLogRepository : BaseRepository<T_LoginLog>, IT_LoginLogRepository
    {

    }
}
