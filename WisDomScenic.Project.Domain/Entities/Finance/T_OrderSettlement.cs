using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_OrderSettlement")]
    [DataContract]
    public class T_OrderSettlement : Entity
    {
        /// <summary>
        /// 企业ID
        /// </summary> 
        [DataMember]
        public Guid EnterpriseId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary> 
        [DataMember]
        public string OrderNo { get; set; }
        /// <summary>
        /// 订单名称
        /// </summary> 
        [DataMember]
        public string OrderName { get; set; }
        /// <summary>
        /// 订单类型【1：农产品】【2：门票】
        /// </summary> 
        [DataMember]
        public int OrderClassify { get; set; }
        /// <summary>
        /// 订单总金额
        /// </summary> 
        [DataMember]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 结算总金额
        /// </summary> 
        [DataMember]
        public decimal SettlementAmount { get; set; }
        /// <summary>
        /// 开始结算日期
        /// </summary> 
        [DataMember]
        public DateTime StartSettlementTime { get; set; }
        /// <summary>
        /// 结算结算日期
        /// </summary> 
        [DataMember]
        public DateTime EndSettlementTime { get; set; }
        /// <summary>
        /// 状态【1：待结算】【2：已结算】
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
    }
}
