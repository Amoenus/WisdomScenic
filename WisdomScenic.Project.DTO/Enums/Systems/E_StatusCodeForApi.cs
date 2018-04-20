
namespace WisdomScenic.Project.DTO.Enums
{
    public enum E_StatusCodeForApi
    {
        [EnumDisplayName("请求(或处理)成功")]
        Success = 200, //请求(或处理)成功

        [EnumDisplayName("内部请求出错")]
        Error = 500, //内部请求出错

        [EnumDisplayName("未授权标识")]
        Unauthorized = 401,//未授权标识

        [EnumDisplayName("请求参数不完整或不正确")]
        ParameterError = 400,//请求参数不完整或不正确

        [EnumDisplayName("请求TOKEN失效")]
        TokenInvalid = 403,//请求TOKEN失效

        [EnumDisplayName("HTTP请求类型不合法")]
        HttpMehtodError = 405,//HTTP请求类型不合法

        [EnumDisplayName("HTTP请求不合法,请求参数可能被篡改")]
        HttpRequestError = 406,//HTTP请求不合法

        [EnumDisplayName("该URL已经失效")]
        URLExpireError = 407,//HTTP请求不合法
    }

    public enum E_StatusCodeForSQL
    {
        [EnumDisplayName("您有未下架产品")]
        Error0 = 6000,
        [EnumDisplayName("未完善景区简介")]
        Error1 = 6001,
        [EnumDisplayName("未设置封面图")]
        Error2 = 6002,
        [EnumDisplayName("未设置轮播图")]
        Error3 = 6003,
        [EnumDisplayName("未完善费用说明")]
        Error4 = 6004,
        [EnumDisplayName("未完善预定说明")]
        Error5 = 6005,
        [EnumDisplayName("未完善退改规则")]
        Error6 = 6006,
        [EnumDisplayName("未完善发票说明")]
        Error7 = 6007,
        [EnumDisplayName("未完善重要条款")]
        Error8 = 6008,
        [EnumDisplayName("未完善产品班期")]
        Error9 = 6009,
        [EnumDisplayName("未添加票种")]
        Error10 = 6010,
        [EnumDisplayName("未添加产品")]
        Error11 = 6011,
        [EnumDisplayName("未完善酒店简介")]
        Error12 = 6012,
        [EnumDisplayName("未设置有效房型")]
        Error13 = 6013, 
        [EnumDisplayName("该房型有在售产品，不能下架")]
        Error14 = 6014,
        [EnumDisplayName("该产品库存类型未设置，无法上架")]
        Error15 = 6015,
        [EnumDisplayName("未完善线路行程信息")]
        Error16 = 6016,
        [EnumDisplayName("该资源下有在售产品，不能删除")]
        Error17 = 6017,
        [EnumDisplayName("该账号已禁用")]
        Error18 = 6018,
        [EnumDisplayName("当前登录供应商类型与账号所属供应商不符合")]
        Error19 = 6019,
        [EnumDisplayName("该员工不属于该公司")]
        Error20 = 6020,
        [EnumDisplayName("该产品包含商品，不能删除")]
        Error21 = 6021,
        [EnumDisplayName("包含子菜单，不能删除")]
        Error22 = 6022
    }
}
