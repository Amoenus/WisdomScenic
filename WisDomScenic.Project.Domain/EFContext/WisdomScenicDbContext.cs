using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using WisdomScenic.Project.Domain.Entities;
using WisdomScenic.Project.Infrastructure;

namespace WisdomScenic.Project.Domain.EFContext
{
    public partial class WisdomScenicDbContext : DbContext
    {
        ////数据库迁移用
        //public WisdomScenicDbContext()
        //    : base("name=WisdomScenicDbContextWrite")
        //{

        //}
        public WisdomScenicDbContext(string configKey)
            : base(configKey)
        {
            base.Configuration.AutoDetectChangesEnabled = true;
            base.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

        }
        /// <summary>
        /// 是否开启日志
        /// </summary>
        public bool LogChangesDuringSave { get; set; }
        /// <summary>
        /// 日志业务名称
        /// </summary>
        public string BusinessName { get; set; }
        /// <summary>
        /// 模块Id
        /// </summary>
        public string ModuleKey { get; set; }
        public override int SaveChanges()
        {
            if (LogChangesDuringSave)
            {
                if (!BusinessName.IsEmpty())
                {
                    //根据表示判断用重写的SaveChanges方法，还是普通的上下文SaveChanges方法
                    var entries = from e in this.ChangeTracker.Entries()
                                  where e.State != EntityState.Unchanged
                                  select e;
                    //过滤所有修改了的实体，包括：增加 / 修改 / 删除
                    string operationType = string.Empty;
                    T_LogSetting logsetting = new T_LogSetting();
                    IList<T_LogSettingDetail> logsettingdetails = new List<T_LogSettingDetail>();
                    if (entries != null)
                    {
                        foreach (var entry in entries)
                        {
                            InitLogSetting(entry, logsetting, logsettingdetails);

                        }
                        T_LogSetting.Add(logsetting);
                    } 
                    if (logsettingdetails != null && logsettingdetails.Count() > 0)
                    {
                        T_LogSettingDetail.AddRange(logsettingdetails);
                    }

                }

            }

            return base.SaveChanges();  //返回普通的上下文SaveChanges方法
        }
        private void InitLogSetting(DbEntityEntry entry, T_LogSetting logsetting, IList<T_LogSettingDetail> logsettingdetails)
        {
            logsetting.BusinessName = this.BusinessName;
            logsetting.IP = Net.Ip;
            logsetting.Id = Guid.NewGuid();
            logsetting.TableName = entry.Entity.GetType().Name;
            logsetting.Url = "";
            logsetting.IsDelete = false;
            logsetting.CreatorUserId = entry.CurrentValues["CreatorUserId"].ToGuid();
            logsetting.CreatorTime = DateTime.Now;
            logsetting.DeleteTime = logsetting.CreatorTime;
            logsetting.DeleteUserId = logsetting.CreatorUserId;
            logsetting.LastModifyTime = logsetting.CreatorTime;
            logsetting.LastModifyUserId = logsetting.CreatorUserId;
            logsetting.PrimaryKey = entry.CurrentValues["Id"].ToGuid();
            logsetting.ModuleKey = ModuleKey.ToGuid();
            switch (entry.State)
            {
                case EntityState.Added:
                    logsetting.OperationType = "增加";
                    break;
                case EntityState.Deleted:
                    logsetting.OperationType = "删除";
                    break;
                case EntityState.Modified:
                    logsetting.OperationType = "修改";
                    break;
            }
            StringBuilder sbNewContent = new StringBuilder("{");
            StringBuilder sbOldContent = new StringBuilder("{");
            foreach (var propertyName in entry.CurrentValues.PropertyNames.Where(it => it != "RowVersion"))
            {
                if (entry.CurrentValues[propertyName] != null)
                {
                    //entry.CurrentValues[propertyName].GetType()
                    sbNewContent.AppendFormat("\"{0}\":{1}{2}{1},", propertyName, entry.CurrentValues[propertyName].GetType().Name.ToLower().Equals("string") ? "\"" : "", entry.CurrentValues[propertyName]);
                    if (entry.State.Equals(EntityState.Modified))
                    {
                        DbPropertyValues databaseValues = entry.GetDatabaseValues();
                        if (!propertyName.Equals("RowVersion") && !entry.CurrentValues[propertyName].Equals(databaseValues[propertyName]))
                        {
                            logsettingdetails.Add(new T_LogSettingDetail
                            {
                                Id = Guid.NewGuid(),
                                ColumnName = propertyName,
                                IsDelete = false,
                                LogId = logsetting.Id,
                                NewColumnValue = entry.CurrentValues[propertyName] == null ? " " : entry.CurrentValues[propertyName].ToString(),
                                OldColumnValue = databaseValues[propertyName] == null ? " " : databaseValues[propertyName].ToString(),
                                CreatorTime = DateTime.Now,
                                CreatorUserId = entry.CurrentValues["CreatorUserId"].ToGuid(),
                                DeleteTime = logsetting.CreatorTime,
                                DeleteUserId = logsetting.CreatorUserId,
                                LastModifyTime = logsetting.CreatorTime,
                                LastModifyUserId = logsetting.CreatorUserId
                            });
                        }
                        sbOldContent.AppendFormat("\"{0}\":{1}{2}{1},", propertyName, (databaseValues[propertyName] == null ? " " : databaseValues[propertyName]).GetType().Name.ToLower().Equals("string") ? "\"" : "", (databaseValues[propertyName] == null ? " " : databaseValues[propertyName]));
                    }

                }
            }
            logsetting.NewContent = sbNewContent.ToString().TrimEnd(',') + "}";
            logsetting.OldContent = sbOldContent.ToString().TrimEnd(',') + "}";
        }

    }


    public enum E_DbClassify
    {
        Read = 2,
        Write = 1
    }
}
