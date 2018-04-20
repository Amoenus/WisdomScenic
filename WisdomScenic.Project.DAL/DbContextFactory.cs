using System.Runtime.Remoting.Messaging;
using System.Web;
using WisdomScenic.Project.Domain.EFContext;
using WisdomScenic.Project.IDAL;

namespace WisdomScenic.Project.DAL
{
    public class DbContextFactory : IDbContextFactory
    {
        public E_DbClassify DbClassify { get; set; }
        public WisdomScenicDbContext GetCurrentThreadInstance()
        {
            string connectionName = "WisdomScenicDbContextWrite";
            if (DbClassify.Equals(E_DbClassify.Read))
            {
                connectionName = "WisdomScenicDbContextRead";
            }
            //ECardPassDbContext dbContext = new ECardPassDbContext(connectionName); ;

            WisdomScenicDbContext dbContext = CallContext.GetData(connectionName) as WisdomScenicDbContext;

            if (dbContext == null)  //线程在内存中没有此上下文  
            {
                //如果不存在上下文 创建一个(自定义)EF上下文  并且放在数据内存中去  
                dbContext = new WisdomScenicDbContext(connectionName);
                CallContext.SetData(connectionName, dbContext);
            }
            return dbContext;  
        }

    }
}
