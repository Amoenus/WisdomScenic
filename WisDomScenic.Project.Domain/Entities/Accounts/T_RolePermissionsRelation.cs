using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_RolePermissionsRelation")]
    [DataContract]
    public class T_RolePermissionsRelation : Entity
    {
        /// <summary>
        /// 角色编号
        /// </summary> 
        [DataMember]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 权限编号
        /// </summary> 
        [DataMember]
        public Guid PermissionsId { get; set; }
    }
}
