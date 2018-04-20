using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    /// <summary>
    /// 	常用联系人表
    /// </summary>
    [Table("T_Contacts")]
    [Serializable]
    [DataContract]
    public class T_Contacts : Entity
    {
        /// <summary>
        /// 游客姓名
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [DataMember]
        public string Phone { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [DataMember]
        public int CredentialsType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [DataMember]
        public string Credentials { get; set; }





    }
}
