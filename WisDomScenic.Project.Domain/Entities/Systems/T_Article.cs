using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_Article")]
    [DataContract]
    public class T_Article : Entity
    {
        /// <summary>
        /// 标题
        /// </summary> 
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// 文章类型【1：公告】【2：新闻】【3：通知】
        /// </summary> 
        [DataMember]
        public int ArticleClassify { get; set; }
        /// <summary>
        /// 内容
        /// </summary> 
        [DataMember]
        public string Content { get; set; }
        /// <summary>
        /// 发布对象
        /// </summary> 
        [DataMember]
        public int PublicObject { get; set; }
        /// <summary>
        /// 状态
        /// </summary> 
        [DataMember]
        public int Status { get; set; }
    }
}
