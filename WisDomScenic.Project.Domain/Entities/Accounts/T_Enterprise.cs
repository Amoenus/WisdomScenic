using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_Enterprise")]
    [DataContract]
    public class T_Enterprise : Entity
    {
        /// <summary>
        /// 企业名称
        /// </summary> 
        [DataMember]
        public string EnterpriseName { get; set; }
        /// <summary>
        /// 业务类型【1：农户】【2：商户】
        /// </summary> 
        [DataMember]
        public string BusinessType { get; set; }
        /// <summary>
        /// 业务范围【1：游乐项目】【2：酒店/民宿】【3：农场品】【4：土特产】
        /// </summary> 
        [DataMember]
        public string BusinessRang { get; set; }
        /// <summary>
        /// 税号
        /// </summary> 
        [DataMember]
        public string TaxNo { get; set; }
        /// <summary>
        /// 传真
        /// </summary> 
        [DataMember]
        public string Fax { get; set; }
        /// <summary>
        /// 联系人
        /// </summary> 
        [DataMember]
        public string Contact { get; set; }
        /// <summary>
        /// 手机号
        /// </summary> 
        [DataMember]
        public string Phone { get; set; }
        /// <summary>
        /// 地址ID
        /// </summary> 
        [DataMember]
        public Guid AddressId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary> 
        [DataMember]
        public string Address { get; set; }
        /// <summary>
        /// 结算周期【1：及时】【2：周结】【3：月结】
        /// </summary> 
        [DataMember]
        public int SettlementCycle { get; set; }
        /// <summary>
        /// 费率
        /// </summary> 
        [DataMember]
        public decimal Rate { get; set; }
        /// <summary>
        /// 类型【1：供应商】【2分销商】
        /// </summary> 
        [DataMember]
        public int Classify { get; set; }
        /// <summary>
        /// 提现密码
        /// </summary> 
        [DataMember]
        public string CashPassWord { get; set; }
        /// <summary>
        /// 备注
        /// </summary> 
        [DataMember]
        public string Remark { get; set; }
        /// <summary>
        /// 状态【1：未启用】【2：启用】
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
    }
}
