using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_ProductForSpecialtyVarietiesToFormat")]
    [DataContract]
    public class T_ProductForSpecialtyVarietiesToFormat : Entity
    {
        /// <summary>
        /// 品种ID
        /// </summary> 
        [DataMember]
        public Guid VarietiesId { get; set; }
        /// <summary>
        /// 规格ID
        /// </summary> 
        [DataMember]
        public Guid FormatId { get; set; }
    }
}