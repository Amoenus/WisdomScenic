using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomScenic.Project.Infrastructure.Order
{
    public static class OrderStatus
    {
        public static string GetClientOrderStatus(int OrderStatus, int CancelStatus, int PayStatus)
        {
            string _result = string.Empty;
            if (CancelStatus == 1)
            {
                //已提交/已支付/取消待审核=取消待审核
                _result = "取消待审核";
            }
            else if (CancelStatus == 2)
            {
                //已提交/已支付/已取消=已取消
                _result = "已取消";
            }
            //else if (CancelStatus == 3)
            //{
            //    //已提交/未支付/已取消=已取消
            //    _result = "取消失败";
            //}
            else if (OrderStatus == 1 && PayStatus == 1 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //未确认/未支付/未取消=待确认
                _result = "待确认";
            }
            else if (OrderStatus == 2 && PayStatus == 1 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //已确认/未支付/未取消=已确认
                _result = "待支付";
            }
            else if (OrderStatus == 3 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //待预定/已支付/未取消=待预定
                _result = "待预定";
            }
            else if (OrderStatus == 4 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //出票中/已支付/未取消=出票中
                _result = "出票中";
            }
            else if (OrderStatus == 5 && PayStatus == 2 && (CancelStatus == 0||CancelStatus==3))
            {
                //待入园/已支付/未取消=待入园
                _result = "待入园";
            }
            else if (OrderStatus == 6 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //已取票/已支付/未取消=已取票
                _result = "已取票";
            }
            else if (OrderStatus == 7)
            {
                _result = "出票失败";
            }
            return _result;
        }
        public static string GetClientHotelOrderStatus(int OrderStatus, int CancelStatus, int PayStatus)
        {
            string _result = string.Empty;
            if (CancelStatus == 1)
            {
                //已提交/已支付/取消待审核=取消待审核
                _result = "取消待审核";
            }
            else if (CancelStatus == 2)
            {
                //已提交/已支付/已取消=已取消
                _result = "已取消";
            }
            //else if (CancelStatus == 3)
            //{
            //    //已提交/未支付/已取消=已取消
            //    _result = "取消失败";
            //}
            else if (OrderStatus == 1 && PayStatus == 1 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //未确认/未支付/未取消=待确认
                _result = "待确认";
            }
            else if (OrderStatus == 2 && PayStatus == 1 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //已确认/未支付/未取消=已确认
                _result = "待支付";
            }
            else if (OrderStatus == 3 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //待预定/已支付/未取消=待预定
                _result = "待预定";
            }
            else if (OrderStatus == 4 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //预定中/已支付/未取消=预定中
                _result = "预定中";
            }
            else if (OrderStatus == 5 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //待入住/已支付/未取消=待入住
                _result = "待入住";
            }
            else if (OrderStatus == 6 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //已入住/已支付/未取消=已入住
                _result = "已入住";
            }
            else if (OrderStatus == 7)
            {
                _result = "预定失败";
            }
            return _result;
        }
        public static string GetClientLineOrderStatus(int OrderStatus, int CancelStatus, int PayStatus)
        {
            string _result = string.Empty;
            if (CancelStatus == 1)
            {
                //已提交/已支付/取消待审核=取消待审核
                _result = "取消待审核";
            }
            else if (CancelStatus == 2)
            {
                //已提交/已支付/已取消=已取消
                _result = "已取消";
            }
            //else if (CancelStatus == 3)
            //{
            //    //已提交/未支付/已取消=已取消
            //    _result = "取消失败";
            //}
            else if (OrderStatus == 1 && PayStatus == 1 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //未确认/未支付/未取消=待确认
                _result = "待确认";
            }
            else if (OrderStatus == 2 && PayStatus == 1 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //已确认/未支付/未取消=已确认
                _result = "待支付";
            }
            else if (OrderStatus == 3 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //待预定/已支付/未取消=待预定
                _result = "待预定";
            }
            else if (OrderStatus == 4 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //预定中/已支付/未取消=预定中
                _result = "预定中";
            }
            else if (OrderStatus == 5 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //待入住/已支付/未取消=待入住
                _result = "待出行";
            }
            else if (OrderStatus == 6 && PayStatus == 2 && (CancelStatus == 0 || CancelStatus == 3))
            {
                //已入住/已支付/未取消=已入住
                _result = "已出行";
            }
            else if (OrderStatus == 7)
            {
                _result = "预定失败";
            }
            return _result;
        } 
    }
}
