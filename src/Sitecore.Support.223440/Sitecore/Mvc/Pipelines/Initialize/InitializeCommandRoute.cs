using Sitecore.Configuration;
using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Diagnostics;

namespace Sitecore.Support.Sitecore.Mvc.Pipelines.Initialize
{
  public class InitializeCommandRoute
  {
    #region Original code
    public virtual void Process(PipelineArgs args)
    {
      Assert.ArgumentNotNull(args, "args");
      this.RegisterRoutes(RouteTable.Routes, args);
    }

    protected virtual void RegisterRoutes(RouteCollection routes, PipelineArgs args)
    {
      string commandRoutePrefix = SpeakSettings.Mvc.CommandRoutePrefix;
      routes.MapRoute("Sitecore.Speak.Commands", commandRoutePrefix + "{controller}/{action}");
      routes.MapRoute("Sitecore.Speak", "sitecore/shell/api/sitecore/{controller}/{action}");
    }
    #endregion Original code
  }
}