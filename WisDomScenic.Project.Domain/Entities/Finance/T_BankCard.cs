using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_BankCard")]
    [DataContract]
    public class T_BankCard : Entity
    {
        /// <summary>
        /// 企业ID
        /// </summary> 
        [DataMember]
        public Guid EnterpriseId { get; set; }
        /// <summary>
        /// 账户/法人名称
        /// </summary> 
        [DataMember]
        public string CardName { get; set; }
        /// <summary>
        /// 证件号
        /// </summary> 
        [DataMember]
        public string IDNumber { get; set; }
        /// <summary>
        /// 银行卡类型【1：企业】【2：个人】
        /// </summary> 
        [DataMember]
        public int CardClassify { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary> 
        [DataMember]
        public string CardNumber { get; set; }
        /// <summary>
        /// 开户行
        /// </summary> 
        [DataMember]
        public string Bank { get; set; }
        /// <summary>
        /// 地址ID
        /// </summary> 
        [DataMember]
        public Guid AddressId { get; set; }
        /// <summary>
        /// 分行地址
        /// </summary> 
        [DataMember]
        public string SubBankAddress { get; set; }
        /// <summary>
        /// 手机号
        /// </summary> 
        [DataMember]
        public string Phone { get; set; }
        /// <summary>
        /// 状态
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
    }
}
