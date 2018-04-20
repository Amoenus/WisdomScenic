using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductForSpecialtyName")]
    [DataContract]
    public class T_ProductForSpecialtyName : Entity
    {
        /// <summary>
        /// 农产品名称
        /// </summary> 
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 农产品分类
        /// </summary> 
        [DataMember]
        public Guid ProductCategoriesId { get; set; }
    }
}