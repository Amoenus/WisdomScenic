using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductCategories")]
    [DataContract]
    public class T_ProductCategories : Entity
    {
        /// <summary>
        /// 分类类型
        /// </summary> 
        [DataMember]
        public int CateClassify { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary> 
        [DataMember]
        public string CateName { get; set; } 
    }
}
