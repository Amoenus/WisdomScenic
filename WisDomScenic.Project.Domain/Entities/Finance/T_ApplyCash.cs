using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ApplyCash")]
    [DataContract]
    public class T_ApplyCash : Entity
    {
        /// <summary>
        /// 企业ID
        /// </summary> 
        [DataMember]
        public Guid EnterpriseId { get; set; }
        /// <summary>
        /// 提现金额
        /// </summary> 
        [DataMember]
        public decimal Amount { get; set; }
        /// <summary>
        /// 状态【1：待审核】【2：审核通过】【3：审核拒绝】
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
        /// <summary>
        /// 操作理由
        /// </summary> 
        [DataMember]
        public string OptionReason { get; set; }
        /// <summary>
        /// 银行卡ID
        /// </summary> 
        [DataMember]
        public Guid BankId { get; set; }
    }
}
