using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WisdomScenic.Project.WebApi.WebLibrary;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using WisdomScenic.Project.Domain.EFContext;
using System.Configuration;
using System.Data.Entity.Infrastructure;
namespace WisdomScenic.Project.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(Server.MapPath("~/Configs/Log4net.config")));
            AutofacContainerBuilder.BuildContainer();
            using (var dbcontext = new WisdomScenicDbContext("WisdomScenicDbContextWrite"))
            {
                var objectContext = ((IObjectContextAdapter)dbcontext).ObjectContext;
                var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                mappingCollection.GenerateViews(new List<EdmSchemaError>());
            }
            GlobalConfiguration.Configure(WebApiConfig.Register);
  
        }
    }
}
