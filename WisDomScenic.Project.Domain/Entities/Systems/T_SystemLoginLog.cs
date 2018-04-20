using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    /// <summary>
    /// 系统登录日志表
    /// </summary>
    [Table("T_SystemLoginLog")]
    [Serializable]
    [DataContract]
    public class T_SystemLoginLog : Entity
    {
        /// <summary>
        /// 账户名
        /// </summary>
        [DataMember]
        public string Account { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        [DataMember]
        public string Ip { get; set; }
    }
}
