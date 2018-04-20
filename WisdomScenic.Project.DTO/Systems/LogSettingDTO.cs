using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomScenic.Project.DTO.Systems
{
    public class LogSettingDTO : GridDataRequest
    {
        /// <summary>
        /// Key
        /// </summary>
        public Guid Key { get; set; }
        /// <summary>
        /// 是否是模块
        /// </summary>
        public bool IsModule { get; set; }
    }
}
