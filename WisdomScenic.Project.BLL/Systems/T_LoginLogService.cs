using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomScenic.Project.Domain.Entities;
using WisdomScenic.Project.IBLL.Systems;
using WisdomScenic.Project.IDAL.Systems;
using WisdomScenic.Project.Infrastructure;

namespace WisdomScenic.Project.BLL.Systems
{
    public class T_LoginLogService : BaseService<T_LoginLog>, IT_LoginLogService
    {
        public override bool SetCurrentRepository()
        {
            this.CurrentRepository = DIContainer.Resolve<IT_LoginLogRepository>();
            base.AddDisposableObject(base.CurrentRepository);
            return true;
        }
    }
}
