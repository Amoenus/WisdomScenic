using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    /// <summary>
    /// 系统基本设置表
    /// </summary>
    [Serializable]
    [Table("T_SystemBasicSetting")]
    [DataContract]
    public class T_SystemBasicSetting : Entity
    {
        /// <summary>
        /// /网站logo
        /// </summary>
        [DataMember]
        public string Logo { get; set; }
        /// <summary>
        /// 网站标题
        /// </summary>
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// 网站关键字
        /// </summary>
        [DataMember]
        public string SeoKeyWrod { get; set; }
        /// <summary>
        /// 网站描叙
        /// </summary>
        [DataMember]
        public string SeoDescription { get; set; }
        /// <summary>
        /// b2c农产品取消时间  单位：小时
        /// </summary>
        [DataMember]
        public int CancelTimeForB2CToSpecialty { get; set; }
        /// <summary>
        /// b2c票务取消时间 单位：小时
        /// </summary>
        [DataMember]
        public int CancelTimeForB2CToTicket { get; set; }
        /// <summary>
        /// 游客中心票务取消时间 单位：小时
        /// </summary>
        [DataMember]
        public int CancelTimeForTouristToSpecialty { get; set; }
        /// <summary>
        /// 农产品自动收货时间 单位：天
        /// </summary>
        [DataMember]
        public int GoodsReceiptToSpecialty { get; set; }

    }
}
