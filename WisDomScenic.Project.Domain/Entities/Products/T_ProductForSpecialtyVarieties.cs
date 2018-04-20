using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductForSpecialtyVarieties")]
    [DataContract]
    public class T_ProductForSpecialtyVarieties : Entity
    {
        /// <summary>
        /// 产品分类ID
        /// </summary> 
        [DataMember]
        public Guid ProductCategoryId { get; set; }
        /// <summary>
        /// 农产品名称ID
        /// </summary> 
        [DataMember]
        public Guid SpecialtyNameId { get; set; }
        /// <summary>
        /// 品种名称
        /// </summary> 
        [DataMember]
        public string VarietiesName { get; set; }
        /// <summary>
        /// 状态
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
    }
}
