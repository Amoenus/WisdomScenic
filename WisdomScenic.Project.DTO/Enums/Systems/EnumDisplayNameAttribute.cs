using System;
using System.Collections.Generic;
using System.Reflection;

namespace WisdomScenic.Project.DTO.Enums
{
    /// <summary>
    /// 可以为枚举项上面标注自定义特性
    /// </summary>
    public class EnumDisplayNameAttribute : Attribute
    {
        private string _displayName;
        public EnumDisplayNameAttribute(string displayName)
        {
            _displayName = displayName;
        }
        public string DisplayName
        {
            get { return _displayName; }
        }

        public static string GetEnumDescription(object e)
        {
            Type t = e.GetType();
            //获取枚举项的字段
            FieldInfo[] fis = t.GetFields();
            foreach (FieldInfo fi in fis)
            {
                //如果当前字段名称不是当前枚举项
                if (fi.Name != e.ToString())
                {
                    continue;//结束本次循环
                }
                //如果当前字段的包含自定义特性
                if (fi.IsDefined(typeof(EnumDisplayNameAttribute), true))
                {
                    //获取自定义特性的属性值
                    return (fi.GetCustomAttributes(typeof(EnumDisplayNameAttribute), true)[0] as EnumDisplayNameAttribute).DisplayName;
                }
            }
            return e.ToString();
        }

        public static List<Selectlistitem> GetSelectList(Type enumType)
        {
            List<Selectlistitem> selectList = new List<Selectlistitem>();
            //selectList.Add(new SelectListItem{Text = "--请选择--",Value = ""});
            foreach (object e in Enum.GetValues(enumType))
            {
                selectList.Add(new Selectlistitem { Text = GetEnumDescription(e), Value = ((int)e).ToString() });
            }
            return selectList;
        }
        public static List<Selectlistitem> GetSelectList(Type enumType, object noContain)
        {
            List<Selectlistitem> selectList = new List<Selectlistitem>();
            foreach (object e in Enum.GetValues(enumType))
            {
                if (!e.Equals(noContain))
                {
                    selectList.Add(new Selectlistitem { Text = GetEnumDescription(e), Value = ((int)e).ToString() });
                }
            }
            return selectList;
        }
    }
    public class Selectlistitem
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class FindEnum
    {

    }
}
