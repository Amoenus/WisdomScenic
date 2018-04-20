using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductBasic")]
    [DataContract]
    public class T_ProductBasic : Entity
    {
        /// <summary>
        /// 产品名称
        /// </summary> 
        [DataMember]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品分类ID
        /// </summary> 
        [DataMember]
        public Guid ProductCategoriesId { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary> 
        [DataMember]
        public string ProductNumber { get; set; }
        /// <summary>
        /// 最低市场价
        /// </summary> 
        [DataMember]
        public decimal MinMarkPrice { get; set; }
        /// <summary>
        /// 最低分销价
        /// </summary> 
        [DataMember]
        public decimal MinDistributionPrice { get; set; }
        /// <summary>
        /// 最低结算价
        /// </summary> 
        [DataMember]
        public decimal MinSettlementPrice { get; set; }
        /// <summary>
        /// 库存类型【1：班期日历库存】【2：总库存】
        /// </summary> 
        [DataMember]
        public int InventoryClassify { get; set; }
        /// <summary>
        /// 供应商ID
        /// </summary> 
        [DataMember]
        public Guid SupplierId { get; set; }
        /// <summary>
        /// 状态【1：未上架】【2：上架审核】【3：已上架】【4：拒绝上架】
        /// </summary> 
        [DataMember]
        public string Status { get; set; }
        /// <summary>
        /// 拒绝理由
        /// </summary> 
        [DataMember]
        public string Reason { get; set; }
        /// <summary>
        /// 类型【1：农产品】【2：门票】
        /// </summary> 
        [DataMember]
        public int Classify { get; set; }
        /// <summary>
        /// 排序
        /// </summary> 
        [DataMember]
        public int Sort { get; set; }
        /// <summary>
        /// 下架时间
        /// </summary> 
        [DataMember]
        public DateTime OffSaleTime { get; set; } 
    }
}
