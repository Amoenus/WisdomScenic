using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WisdomScenic.Project.Domain.Entities;
using WisdomScenic.Project.Infrastructure;

namespace WisdomScenic.Project.WebApi.WebLibrary
{
    public class ApiBaseController : ApiController
    {
        protected IList<IDisposable> DisposableObjects { get; private set; }
        #region 资源释放
        protected void AddDisposableObject(object obj)
        {
            IDisposable disposable = obj as IDisposable;
            if (disposable != null)
            {
                this.DisposableObjects.Add(disposable);
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (IDisposable obj in this.DisposableObjects)
                {
                    if (null != obj)
                    {
                        obj.Dispose();
                    }
                }
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}