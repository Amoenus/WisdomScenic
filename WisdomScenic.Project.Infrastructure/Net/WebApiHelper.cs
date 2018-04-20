
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using System.Xml;
using System.Web;
using WisdomScenic.Project.Infrastructure.DingTalk;
using WisdomScenic.Project.Infrastructure.Extend;
namespace WisdomScenic.Project.Infrastructure
{
    public class WebApiHelper
    {
        private static readonly HttpClient _httpClient_WisdomScenicApi;
        static WebApiHelper()
        {
            _httpClient_WisdomScenicApi = new HttpClient();
            _httpClient_WisdomScenicApi.DefaultRequestHeaders.Connection.Add("keep-alive");
            _httpClient_WisdomScenicApi.Timeout = TimeSpan.FromSeconds(90);
            //httpClient预连接
            //_httpClient_WisdomScenicApi.SendAsync(new HttpRequestMessage
            //{
            //    Method = HttpMethod.Head,
            //    RequestUri = new Uri(AppSettingsConfig.GetTokenApi + "/api/Service/HttpClientPreheat")
            //}).Result.EnsureSuccessStatusCode();
        }
        private static bool SendDingTalk(string text)
        {
            bool result = false;
            try
            {
               
                if (HttpContext.Current.Request.Url.Host.IsOnline())
                {
                    TextMessage message = new TextMessage
                    {
                        At = new AtMobiles
                        {

                            Lst = new List<string> { "13817270825" }
                        },
                        IsAtAll = false,
                        MsgType = MsgType.text.ToString(),
                        Text = new Content
                        {
                            Description = text + "IP:" + Net.Ip
                        }
                    };
                    result = Robot.Send(message);
                }
            }
            catch (Exception)
            {
                
            }
    
            return result;
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="staffId"></param>
        /// <returns></returns>
        public static T Post<T>(string url, string data, int staffId)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                string timeStamp = GetTimeStamp();
                string nonce = GetRandom();
                //加入头信息

                request.Headers.Add("staffid", staffId.ToString()); //当前请求用户StaffId
                request.Headers.Add("Staffkey", ConfigurationManager.AppSettings[staffId.ToString()]);
                request.Headers.Add("timestamp", timeStamp); //发起请求时的时间戳（单位：毫秒）
                request.Headers.Add("nonce", nonce); //发起请求时的时间戳（单位：毫秒）
                request.Headers.Add("signature", GetSignature(timeStamp, nonce, staffId)); //当前请求内容的数字签名

                //写数据
                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "application/json";
                //读数据
                request.Timeout = 300000;
                request.Headers.Set("Pragma", "no-cache");

                Stream reqstream = request.GetRequestStream();
                reqstream.Write(bytes, 0, bytes.Length);


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                string strResult = streamReader.ReadToEnd();

                //关闭流
                reqstream.Close();
                streamReader.Close();
                streamReceive.Close();
                request.Abort();
                response.Close();
                return JsonConvert.DeserializeObject<T>(strResult);

            }
            catch (Exception ex)
            {
                SendDingTalk(ex.StackTrace);
                throw;
            }

        }
        /// <summary>
        /// 异步POST请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="staffId"></param>
        /// <returns></returns>
        public static async Task<T> PostAsync<T>(string url, string data, int staffId)
        {
            //加入头信息
            string timeStamp = GetTimeStamp();
            string nonce = GetRandom();
            HttpContent httpContent = new StringContent(data, Encoding.UTF8, "application/json");
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, new Uri(url));
            requestMessage.Headers.Add("staffid", staffId.ToString()); //当前请求用户StaffId
            requestMessage.Headers.Add("Staffkey", ConfigurationManager.AppSettings[staffId.ToString()]);

            requestMessage.Headers.Add("timestamp", timeStamp); //发起请求时的时间戳（单位：毫秒）
            requestMessage.Headers.Add("nonce", nonce); //发起请求时的时间戳（单位：毫秒）
            requestMessage.Headers.Add("signature", GetSignature(timeStamp, nonce, staffId)); //当前请求内容的数字签名
            requestMessage.Content = httpContent;
            var response = await _httpClient_WisdomScenicApi.SendAsync(requestMessage);
            //response.EnsureSuccessStatusCode();
            if (!response.IsSuccessStatusCode)
            {
                SendDingTalk(response.Content.ReadAsStringAsync().Result);
                throw new Exception(response.Content.ReadAsStringAsync().Result);

            }
            else
            {
                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
        }
        /// <summary>
        /// Get请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="webApi"></param>
        /// <param name="queryStr"></param>
        /// <param name="staffId"></param>
        /// <returns></returns>
        public static T Get<T>(string webApi, string query, string queryStr, int staffId, bool sign = true)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webApi + "?" + queryStr);
                string timeStamp = GetTimeStamp();
                string nonce = GetRandom();
                //加入头信息
                request.Headers.Add("staffid", staffId.ToString()); //当前请求用户StaffId
                request.Headers.Add("Staffkey", ConfigurationManager.AppSettings[staffId.ToString()]);

                request.Headers.Add("timestamp", timeStamp); //发起请求时的时间戳（单位：毫秒）
                request.Headers.Add("nonce", nonce); //随机数

                if (sign)
                    request.Headers.Add("signature", GetSignature(timeStamp, nonce, staffId)); //当前请求内容的数字签名

                request.Method = "GET";
                request.ContentType = "application/json";
                request.Timeout = 90000;
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                string strResult = streamReader.ReadToEnd();

                streamReader.Close();
                streamReceive.Close();
                request.Abort();
                response.Close();

                return JsonConvert.DeserializeObject<T>(strResult);
            }
            catch (Exception ex)
            {
                SendDingTalk(ex.StackTrace);
                throw;
            }
        }
        /// <summary>
        /// 异步GET请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="webApi"></param>
        /// <param name="query"></param>
        /// <param name="queryStr"></param>
        /// <param name="staffId"></param>
        /// <param  name="sign"></param>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(string webApi, string query, string queryStr, int staffId, bool sign = true)
        {
            string uri = webApi + "?" + queryStr;
            //加入头信息
            string timeStamp = GetTimeStamp();
            string nonce = GetRandom();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, new Uri(uri));
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.Add("staffid", staffId.ToString()); //当前请求用户StaffId
            requestMessage.Headers.Add("Staffkey", ConfigurationManager.AppSettings[staffId.ToString()]);
            requestMessage.Headers.Add("timestamp", timeStamp); //发起请求时的时间戳（单位：毫秒）
            requestMessage.Headers.Add("nonce", nonce); //发起请求时的时间戳（单位：毫秒）
            if (sign)
            {
                requestMessage.Headers.Add("signature", GetSignature(timeStamp, nonce, staffId)); //当前请求内容的数字签名
            }
            var response = await _httpClient_WisdomScenicApi.SendAsync(requestMessage);
            if (!response.IsSuccessStatusCode)
            {
                SendDingTalk(response.Content.ReadAsStringAsync().Result);
                throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
            //response.EnsureSuccessStatusCode();
            //return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }


        /// <summary>
        /// 获取token 保存
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static string GetSignToken(int staffId)
        {
            string _resultToken = string.Empty;
            DateTime _expireTime = DateTime.Now;
            bool _hasstaffId = false;
            XmlNode Node = GetNode(staffId.ToString());
            if (Node != null)
            {
                _resultToken = Node.Attributes["signToken"].Value;
                _expireTime = Convert.ToDateTime(Node.Attributes["expireTime"].Value);
                _hasstaffId = true;
            }
            if (!_hasstaffId) //xml没有
            {
                Token _token = GetApiToken(staffId);
                _resultToken = _token.SignToken.ToString();
                _expireTime = _token.ExpireTime.AddHours(-2); //提前两小时过期
                OptXml(staffId.ToString(), _expireTime, _resultToken, null);
            }
            else if (DateTime.Now > _expireTime) //token过期
            {
                Token _token = GetApiToken(staffId);
                _resultToken = _token.SignToken.ToString();
                _expireTime = _token.ExpireTime.AddHours(-2);//提前两小时过期
                OptXml(staffId.ToString(), _expireTime, _resultToken, Node);
            }
            else
            {
                _resultToken = Node.Attributes["signToken"].Value;
            }
            return _resultToken;
        }
        #region api Token 存储xml操作
        private static Token GetApiToken(int staffId)
        {
            string tokenApi = ConfigurationManager.AppSettings["TokenApi"];
            Dictionary<string, string> parames = new Dictionary<string, string>();
            parames.Add("staffId", staffId.ToString());
            Tuple<string, string> parameters = GetQueryString(parames);
            Token token = WebApiHelper.Get<TokenResultMsg>(tokenApi + "api/Service/GetToken", parameters.Item1, parameters.Item2, staffId, false).Result;
            return token;
        }

        private static void OptXml(string staffId, DateTime expireTime, string signToken, XmlNode oldNode)
        {
            string filepath = HttpContext.Current == null ? System.IO.Path.Combine(HttpRuntime.AppDomainAppPath, "ApiToken.xml") : HttpContext.Current.Server.MapPath("~/ApiToken.xml");
            XmlDocument xml = GetDocument();
            if (oldNode != null)
            {
                XmlNodeList Lst = xml.SelectSingleNode("//xml").ChildNodes;
                foreach (XmlNode item in Lst)
                {
                    if (item.Attributes["staffId"].Value == staffId)
                    {
                        xml.SelectSingleNode("//xml").RemoveChild(item);
                    }
                }
            }
            XmlElement xmlElement = xml.CreateElement("ApiToken");
            xmlElement.SetAttribute("signToken", signToken);
            xmlElement.SetAttribute("expireTime", expireTime.ToString("yyyy-MM-dd HH:mm:ss"));
            xmlElement.SetAttribute("staffId", staffId);
            xml.SelectSingleNode("//xml").AppendChild(xmlElement);
            try
            {
                xml.Save(filepath);
            }
            catch (Exception)
            {

            }

        }

        private static XmlNode GetNode(string staffId)
        {
            XmlDocument xml = GetDocument();
            XmlNode node = null;
            XmlNodeList Lst = xml.SelectSingleNode("//xml").ChildNodes;
            foreach (XmlNode item in Lst)
            {
                if (item.Attributes["staffId"].Value == staffId)
                {
                    node = item;
                    break;
                }
            }
            return node;
        }
        #endregion

        private static XmlDocument GetDocument()
        {
            string filepath = HttpContext.Current == null ? System.IO.Path.Combine(HttpRuntime.AppDomainAppPath, "ApiToken.xml") : HttpContext.Current.Server.MapPath("~/ApiToken.xml");
            StreamReader str = new StreamReader(filepath, System.Text.Encoding.UTF8);
            XmlDocument xml = new XmlDocument();
            xml.Load(str);
            str.Close();
            str.Dispose();
            return xml;
        }

        /// <summary>
        /// 获取token
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static async Task<TokenResultMsg> GetSignTokenAsync(int staffId)
        {
            string tokenApi = ConfigurationManager.AppSettings["TokenApi"];
            Dictionary<string, string> parames = new Dictionary<string, string>();
            parames.Add("staffId", staffId.ToString());
            Tuple<string, string> parameters = GetQueryString(parames);
            TokenResultMsg token = await WebApiHelper.GetAsync<TokenResultMsg>(tokenApi, parameters.Item1, parameters.Item2, staffId, false);
            return token;
        }
        #region MyRegion

        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="nonce"></param>
        /// <param name="staffId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        //private static string GetSignature(string timeStamp, string nonce, int staffId, string data)
        //{
        //    Token token = null;
        //    var resultMsg = GetSignToken(staffId);
        //    if (resultMsg != null)
        //    {
        //        if (resultMsg.StatusCode == 200)
        //        {
        //            token = resultMsg.Result;
        //        }
        //        else
        //        {
        //            throw new Exception(resultMsg.Info.ToString());
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("token为null，员工编号为：" + staffId);
        //    }

        //    var hash = System.Security.Cryptography.MD5.Create();
        //    //拼接签名数据
        //    var signStr = timeStamp + nonce + staffId + token.SignToken.ToString() + data;
        //    //将字符串中字符按升序排序
        //    var sortStr = string.Concat(signStr.OrderBy(c => c));
        //    var bytes = Encoding.UTF8.GetBytes(sortStr);
        //    //使用MD5加密
        //    var md5Val = hash.ComputeHash(bytes);
        //    //把二进制转化为大写的十六进制
        //    StringBuilder result = new StringBuilder();
        //    foreach (var c in md5Val)
        //    {
        //        result.Append(c.ToString("X2"));
        //    }
        //    return result.ToString().ToUpper();
        //}
        #endregion

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="timeStamp">发起请求时的时间戳（单位：毫秒）</param>
        /// <param name="nonce">随机数</param>
        /// <param name="staffId">应用编号</param>
        /// <param name="token">token</param>
        public static string GetSignature(string timeStamp, string nonce, int staffId)
        {

            string _signToken = GetSignToken(staffId);
            string signature = timeStamp + nonce + +staffId + _signToken;
            string resultMsg = Md5.Md5Hash(signature);
            return resultMsg;
        }
        /// <summary>  
        /// 获取时间戳  
        /// </summary>  
        /// <returns></returns>  
        private static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }


        /// <summary>  
        /// 获取随机数
        /// </summary>  
        /// <returns></returns>  
        private static string GetRandom()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int i = rd.Next(0, int.MaxValue);
            return i.ToString();
        }


        /// <summary>
        /// 拼接get参数
        /// </summary>
        /// <param name="parames"></param>
        /// <returns></returns>
        public static Tuple<string, string> GetQueryString(Dictionary<string, string> parames)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parames);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder("");  //签名字符串
            StringBuilder queryStr = new StringBuilder(""); //url参数
            if (parames == null || parames.Count == 0)
                return new Tuple<string, string>("", "");

            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key))
                {
                    query.Append(key).Append(value);
                    queryStr.Append("&").Append(key).Append("=").Append(value);
                }
            }

            return new Tuple<string, string>(query.ToString(), queryStr.ToString().Substring(1, queryStr.Length - 1));
        }

    }
}
