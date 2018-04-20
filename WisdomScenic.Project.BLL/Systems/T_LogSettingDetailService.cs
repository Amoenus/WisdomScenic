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
    public class T_LogSettingDetailService : BaseService<T_LogSettingDetail>, IT_LogSettingDetailService
    {
        public override bool SetCurrentRepository()
        {
            this.CurrentRepository = DIContainer.Resolve<IT_LogSettingDetailRepository>();
            base.AddDisposableObject(base.CurrentRepository);
            return true;
        }
    }
}
