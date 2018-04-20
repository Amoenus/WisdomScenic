using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomScenic.Project.Domain.EFContext;

namespace WisdomScenic.Project.IDAL
{
    public interface IDbContextFactory
    {
        E_DbClassify DbClassify { get; set; }
        WisdomScenicDbContext GetCurrentThreadInstance();
    }
}
