using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomScenic.Project.Domain.Entities;
using WisdomScenic.Project.IBLL.Systems;
using WisdomScenic.Project.IDAL.Systems;
using WisdomScenic.Project.Infrastructure;
using WisdomScenic.Project.DTO.Systems;
namespace WisdomScenic.Project.BLL.Systems
{
    public class T_LogSettingService : BaseService<T_LogSetting>, IT_LogSettingService
    {
        public override bool SetCurrentRepository()
        {
            this.CurrentRepository = DIContainer.Resolve<IT_LogSettingRepository>();
            base.AddDisposableObject(base.CurrentRepository);
            return true;
        }
        /// <summary>
        /// 得到操作日志根据主键或模块编号
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IList<T_LogSetting> FindLogSetting(LogSettingDTO param)
        {

            var _whereLambda = ExtLinq.True<T_LogSetting>();
            _whereLambda = _whereLambda.And(it => it.IsDelete == false);
            if (!param.Key.IsEmpty())
            {
                _whereLambda = _whereLambda.And(it => it.PrimaryKey == param.Key || it.ModuleKey == param.Key);
            }
            int _records = 0;
            var _lst = CurrentRepository.LoadPageEntitiesOrderByField(
                _whereLambda,
                param.Field,
                param.Limit,
                param.Page,
                out _records,
                param.Sort.ToLower().Equals("asc")
                ).ToList();
            return _lst;
        }


    }
}
