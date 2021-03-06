﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace WisdomScenic.Project.Infrastructure
{
    public static partial class Ext
    {
        public static HttpResponseMessage ResponseMessage(this Object obj)
        {
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                str = obj.ToJson();
            }
            HttpResponseMessage result = new HttpResponseMessage
            {
                Content = new StringContent(
                    str,
                    Encoding.GetEncoding("UTF-8"),
                    "application/json")
            };
            return result;
        }
    }
}
