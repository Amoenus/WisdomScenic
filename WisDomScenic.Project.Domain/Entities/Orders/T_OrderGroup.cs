using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_OrderGroup")]
    [DataContract]
    public class T_OrderGroup : Entity
    {
        /// <summary>
        /// 订单名称
        /// </summary> 
        [DataMember]
        public string OrderGroupName { get; set; }
        /// <summary>
        /// 订单分组编号
        /// </summary> 
        [DataMember]
        public string GroupOrderNo { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary> 
        [DataMember]
        public string OrderNoStr { get; set; }
        /// <summary>
        /// 支付流水号
        /// </summary> 
        [DataMember]
        public string PayTransactionNo { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary> 
        [DataMember]
        public int PayClassify { get; set; }
        /// <summary>
        /// 总金额
        /// </summary> 
        [DataMember]
        public decimal TotalAmount { get; set; }
    }
}
