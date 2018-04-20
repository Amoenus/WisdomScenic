using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_RefundableRecord")]
    [DataContract]
    public class T_RefundableRecord : Entity
    {
        /// <summary>
        /// 订单编号
        /// </summary> 
        [DataMember]
        public string OrderNo { get; set; }
        /// <summary>
        /// 理由
        /// </summary> 
        [DataMember]
        public string Reason { get; set; }
        /// <summary>
        /// 详细理由
        /// </summary> 
        [DataMember]
        public string ReasonDetail { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary> 
        [DataMember]
        public int ProductQuantity { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary> 
        [DataMember]
        public int OptionClassify { get; set; }
        /// <summary>
        /// 状态
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
    }
}
