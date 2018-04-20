using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductForSpecialty")]
    [DataContract]
    public class T_ProductForSpecialty : Entity
    {
        /// <summary>
        /// 产品ID
        /// </summary> 
        [DataMember]
        public Guid ProductId { get; set; }
        /// <summary>
        /// 品种ID
        /// </summary> 
        [DataMember]
        public Guid VarietiesId { get; set; }
        /// <summary>
        /// 产品规格
        /// </summary> 
        [DataMember]
        public string SpecsStr { get; set; }
        /// <summary>
        /// 产品说明
        /// </summary> 
        [DataMember]
        public string SpecialtyExplain { get; set; }
        /// <summary>
        /// 销售模式【1：现售】【2：预售】
        /// </summary> 
        [DataMember]
        public int SalesModel { get; set; }
        /// <summary>
        /// 定金比例
        /// </summary> 
        [DataMember]
        public decimal DepositRatio { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary> 
        [DataMember]
        public string SaleslUnit { get; set; }
        /// <summary>
        /// 配送方式【1：快递配送】【2：上门自取】
        /// </summary> 
        [DataMember]
        public int Deliveries { get; set; }
        /// <summary>
        /// 快递费
        /// </summary> 
        [DataMember]
        public decimal ExpressFee { get; set; }
        /// <summary>
        /// 供货时间
        /// </summary> 
        [DataMember]
        public DateTime SupplierTime { get; set; }
    }
}
