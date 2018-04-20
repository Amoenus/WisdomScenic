using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    /// <summary>
    /// T_Tourist    	游客表
    /// </summary>
    [Serializable]
    [Table("T_Tourist")]
    [DataContract]
    public class T_Tourist : Entity
    { 
        /// <summary>
        /// 订单ID
        /// </summary>
        [DataMember]
        public Guid OrderId { get; set; } 
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [DataMember]
        public Guid OrderDetailId { get; set; } 
        /// <summary>
        /// 游客姓名
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        public string Sex { get; set; }
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
        /// <summary>
        /// 是否为取票人
        /// </summary>
        [DataMember]
        public bool IsTicket { get; set; }
    }
}
