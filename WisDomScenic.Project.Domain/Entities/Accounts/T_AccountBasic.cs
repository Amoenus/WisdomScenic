using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_AccountBasic")]
    [DataContract]
    public class T_AccountBasic : Entity
    {
        /// <summary>
        /// 主账号
        /// </summary> 
        [DataMember]
        public bool IsMaster { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary> 
        [DataMember]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary> 
        [DataMember]
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 职位ID
        /// </summary> 
        [DataMember]
        public Guid JobID { get; set; }
        /// <summary>
        /// 手机号
        /// </summary> 
        [DataMember]
        public string Phone { get; set; }
        /// <summary>
        /// 身份证
        /// </summary> 
        [DataMember]
        public string ID_Card { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary> 
        [DataMember]
        public string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary> 
        [DataMember]
        public string PassWord { get; set; }
        /// <summary>
        /// 类型 0：【景区运营端用户】1：【C端用户】2：【供应商端用户】3：【分销商端用户】
        /// </summary> 
        [DataMember]
        public int Classify { get; set; }
        /// <summary>
        /// 图像
        /// </summary> 
        [DataMember]
        public string Picture { get; set; }
        /// <summary>
        /// 性别
        /// </summary> 
        [DataMember]
        public string Sex { get; set; }
        /// <summary>
        /// 昵称
        /// </summary> 
        [DataMember]
        public string Nickname { get; set; }
        /// <summary>
        /// 状态 【1：禁用】【2：启用】
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary> 
        [DataMember]
        public string RealName { get; set; }
        /// <summary>
        /// 企业ID
        /// </summary> 
        [DataMember]
        public Guid EnterpriseId { get; set; }
        /// <summary>
        /// 备注
        /// </summary> 
        [DataMember]
        public string Remark { get; set; }
    }
}
