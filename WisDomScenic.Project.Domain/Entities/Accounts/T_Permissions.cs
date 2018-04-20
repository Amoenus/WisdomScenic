using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_Permissions")]
    [DataContract]
    public class T_Permissions : Entity
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Level { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public string Controller { get; set; }
        [DataMember]
        public string Action { get; set; }
        [DataMember]
        public string Param { get; set; }
        [DataMember]
        public int Classify { get; set; }
        [DataMember]
        public Guid ParentId { get; set; }
        [DataMember]
        public int Sort { get; set; }
        [DataMember]
        public string Icon { get; set; }
    }
}
