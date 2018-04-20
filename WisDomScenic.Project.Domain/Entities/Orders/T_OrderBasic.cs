using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WisdomScenic.Project.Domain.Entities
{
    [Serializable]
    [Table("T_OrderBasic")]
    [DataContract]
    public class T_OrderBasic : Entity
    {
        /// <summary>
        /// 订单名称
        /// </summary> 
        [DataMember]
        public string OrderName { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary> 
        [DataMember]
        public string OrderNo { get; set; }
        /// <summary>
        /// 订单分类【1：农产品】【2：门票】
        /// </summary> 
        [DataMember]
        public int Classify { get; set; }
        /// <summary>
        /// 订单总金额
        /// </summary> 
        [DataMember]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary> 
        [DataMember]
        public decimal PreferentialAmount { get; set; }
        /// <summary>
        /// 实际支付金额
        /// </summary> 
        [DataMember]
        public decimal TotalPayAmount { get; set; }
        /// <summary>
        /// 修改后总金额
        /// </summary> 
        [DataMember]
        public decimal UpdateTotalAmount { get; set; }
        /// <summary>
        /// 总运费
        /// </summary> 
        [DataMember]
        public decimal TotalCostsAmount { get; set; }
        /// <summary>
        /// 总数量
        /// </summary> 
        [DataMember]
        public int TotalQuantity { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary> 
        [DataMember]
        public decimal RefundAmount { get; set; }
        /// <summary>
        /// 供应商ID
        /// </summary> 
        [DataMember]
        public Guid SupplierId { get; set; }
        /// <summary>
        /// 处理理由
        /// </summary> 
        [DataMember]
        public string OptionReason { get; set; }
        /// <summary>
        /// 订单状态【1：待支付】【2：待发货】【3：待收货】【4：已付定金】【5：代付尾款】【6：退款中】【7：已退款】【8：已完成】【9：已取消】
        /// </summary> 
        [DataMember]
        public int OrderStatus { get; set; }
        /// <summary>
        /// 取消状态【1：未取消】【2：取消待审核】【3：已取消】【4：取消失败】
        /// </summary> 
        [DataMember]
        public int CancelStatus { get; set; }
        /// <summary>
        /// 支付状态【1：待支付】【2：已支付】
        /// </summary> 
        [DataMember]
        public int PayStatus { get; set; }
        /// <summary>
        /// 配送方式【1：快递配送】【2：上门自取】
        /// </summary> 
        [DataMember]
        public int Deliveries { get; set; }
        /// <summary>
        /// 支付方式【1：微信支付】【2：支付宝支付】
        /// </summary> 
        [DataMember]
        public int PayClassify { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary> 
        [DataMember]
        public DateTime PayTime { get; set; }
        /// <summary>
        /// 支付流水号
        /// </summary> 
        [DataMember]
        public string PayTransactionNo { get; set; }
        /// <summary>
        /// 取消流水号
        /// </summary> 
        [DataMember]
        public string CancelTransactionNo { get; set; }
        /// <summary>
        /// 快递公司
        /// </summary> 
        [DataMember]
        public string ExpressCompany { get; set; }
        /// <summary>
        /// 运单号
        /// </summary> 
        [DataMember]
        public string WaybillNumber { get; set; }
        /// <summary>
        /// 收货人
        /// </summary> 
        [DataMember]
        public string Consignee { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary> 
        [DataMember]
        public string ConsigneeAddress { get; set; }
        /// <summary>
        /// 收货人手机号
        /// </summary> 
        [DataMember]
        public string ConsigneePhone { get; set; }
        /// <summary>
        /// 申请取消时间
        /// </summary> 
        [DataMember]
        public DateTime ApplyCancelTime { get; set; }
        /// <summary>
        /// 取消处理时间
        /// </summary> 
        [DataMember]
        public DateTime OptionCancelTime { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary> 
        [DataMember]
        public DateTime SendProductTime { get; set; }
    }
}
