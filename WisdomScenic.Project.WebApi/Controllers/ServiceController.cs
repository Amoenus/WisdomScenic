using System;
using WisdomScenic.Project.Infrastructure;
using WisdomScenic.Project.DTO.Enums;
using WisdomScenic.Project.WebApi.WebLibrary;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WisdomScenic.Project.WebApi.Controllers
{
    public class ServiceController : ApiBaseController
    {
        /// <summary>
        /// 根据用户名获取token
        /// </summary>
        /// <param name="staffId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<HttpResponseMessage> GetToken(string staffId)
        {
            return await Task.Run(() =>
           {
               ResultMsg resultMsg = new ResultMsg();
               int id = 0;

               //判断参数是否合法
               if (string.IsNullOrEmpty(staffId) || (!int.TryParse(staffId, out id)))
               {
                   resultMsg.StatusCode = (int)E_StatusCodeForApi.ParameterError;
                   resultMsg.Info = EnumDisplayNameAttribute.GetEnumDescription(E_StatusCodeForApi.ParameterError);
                   resultMsg.Data = "";
               }
               else
               {
                   //插入缓存
                   Token token = RedisHelper.Get<Token>(id.ToString());
                   if (token == null)
                   {
                       token = new Token();
                       token.StaffId = id;
                       token.SignToken = Guid.NewGuid();
                       token.ExpireTime = DateTime.Now.AddDays(1);
                       RedisHelper.Set(token.StaffId.ToString(), token, token.ExpireTime);
                   }

                   //返回token信息
                   resultMsg.Data = token;
               }
               return resultMsg.ToJson().ResponseMessage();
           });
        }
        [HttpHead]
        /// <summary>
        /// HttpClient预热
        /// </summary>
        public void HttpClientPreheat()
        {

        }


       
    }
}
