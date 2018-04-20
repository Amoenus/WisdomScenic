using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_OrderItemForSpecialty")]
    [DataContract]
    public class T_OrderItemForSpecialty : Entity
    {
        /// <summary>
        /// 订单ID
        /// </summary> 
        [DataMember]
        public string OrderId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary> 
        [DataMember]
        public string OrderNo { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary> 
        [DataMember]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品ID
        /// </summary> 
        [DataMember]
        public string ProductID { get; set; }
        /// <summary>
        /// 单价
        /// </summary> 
        [DataMember]
        public string Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary> 
        [DataMember]
        public string Quantity { get; set; }
        /// <summary>
        /// 小计
        /// </summary> 
        [DataMember]
        public string SubTotalAmount { get; set; }
        /// <summary>
        /// 定金比例
        /// </summary> 
        [DataMember]
        public string DepositRatio { get; set; }
        /// <summary>
        /// 定金
        /// </summary> 
        [DataMember]
        public string DepositPrice { get; set; }
        /// <summary>
        /// 运费
        /// </summary> 
        [DataMember]
        public string ExpressFee { get; set; }
        /// <summary>
        /// 品种
        /// </summary> 
        [DataMember]
        public string Varieties { get; set; }
        /// <summary>
        /// 规格
        /// </summary> 
        [DataMember]
        public string SpecsStr { get; set; }
        /// <summary>
        /// 单位
        /// </summary> 
        [DataMember]
        public string SalesUnit { get; set; }
        /// <summary>
        /// 销售模式
        /// </summary> 
        [DataMember]
        public string SalesModel { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary> 
        [DataMember]
        public string ProductNo { get; set; }
        /// <summary>
        /// 产品分类名称
        /// </summary> 
        [DataMember]
        public string CategoryName { get; set; }
    }
}
