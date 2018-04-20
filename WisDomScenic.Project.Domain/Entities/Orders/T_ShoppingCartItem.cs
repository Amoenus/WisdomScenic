using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ShoppingCartItem")]
    [DataContract]
    public class T_ShoppingCartItem : Entity
    {
        /// <summary>
        /// 购物车ID
        /// </summary> 
        [DataMember]
        public Guid CartId { get; set; }
        /// <summary>
        /// 供应商ID
        /// </summary> 
        [DataMember]
        public Guid SupplierId { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary> 
        [DataMember]
        public string SupplierName { get; set; }
        /// <summary>
        /// 产品ID
        /// </summary> 
        [DataMember]
        public Guid ProductId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary> 
        [DataMember]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品规格
        /// </summary> 
        [DataMember]
        public string SpecsStr { get; set; }
        /// <summary>
        /// 产品图片
        /// </summary> 
        [DataMember]
        public string ProductImg { get; set; }
        /// <summary>
        /// 单价
        /// </summary> 
        [DataMember]
        public decimal Amount { get; set; }
        /// <summary>
        /// 数量
        /// </summary> 
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// 小计
        /// </summary> 
        [DataMember]
        public decimal SubAmount { get; set; }
        /// <summary>
        /// 运费
        /// </summary> 
        [DataMember]
        public decimal CostsAmount { get; set; }
    }
}
