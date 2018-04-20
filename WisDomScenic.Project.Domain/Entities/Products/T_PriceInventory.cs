using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_PriceInventory")]
    [DataContract]
    public class T_PriceInventory : Entity
    {
        /// <summary>
        /// 价格名称
        /// </summary> 
        [DataMember]
        public string PriceName { get; set; }
        /// <summary>
        /// 外键ID
        /// </summary> 
        [DataMember]
        public Guid ForeignKeyId { get; set; }
        /// <summary>
        /// 外键类型【1：产品】【2：班期日历】
        /// </summary> 
        [DataMember]
        public int ForeignKeyClassify { get; set; }
        /// <summary>
        /// 价格类型【1：结算价】【2：分销价】【3：市场价】
        /// </summary> 
        [DataMember]
        public int PriceClassify { get; set; }
        /// <summary>
        /// 库存
        /// </summary> 
        [DataMember]
        public int Inventory { get; set; }
        /// <summary>
        /// 已售库存
        /// </summary> 
        [DataMember]
        public int SoldInventory { get; set; }
        /// <summary>
        /// 价格
        /// </summary> 
        [DataMember]
        public decimal Price { get; set; } 
    }
}
