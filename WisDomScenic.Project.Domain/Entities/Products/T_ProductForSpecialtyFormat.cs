using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductForSpecialtyFormat")]
    [DataContract]
    public class T_ProductForSpecialtyFormat : Entity
    {
        /// <summary>
        /// 规格名称
        /// </summary> 
        [DataMember]
        public string FormatName { get; set; }
        /// <summary>
        /// 规格参数
        /// </summary> 
        [DataMember]
        public string FormatParms { get; set; }
    }
}
