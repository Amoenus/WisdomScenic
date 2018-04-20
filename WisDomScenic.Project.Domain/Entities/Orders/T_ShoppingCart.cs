using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ShoppingCart")]
    [DataContract]
    public class T_ShoppingCart : Entity
    {
        /// <summary>
        /// 购物车名称
        /// </summary> 
        [DataMember]
        public string CartName { get; set; }
        /// <summary>
        /// 总金额
        /// </summary> 
        [DataMember]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 总数量
        /// </summary> 
        [DataMember]
        public int TotalQuantity { get; set; }
        /// <summary>
        /// 总运费
        /// </summary> 
        [DataMember]
        public decimal TotalCostsAmount { get; set; }
    }
}
