using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductForSpecialtyUnit")]
    [DataContract]
    public class T_ProductForSpecialtyUnit : Entity
    {
        /// <summary>
        /// 单位名称
        /// </summary> 
        [DataMember]
        public string UnitName { get; set; } 
    }
}