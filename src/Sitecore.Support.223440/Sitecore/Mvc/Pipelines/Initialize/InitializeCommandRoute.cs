using Sitecore.Configuration;
using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Mvc.Pipelines.Initialize;

namespace Sitecore.Support.Sitecore.Mvc.Pipelines.Initialize
{
  public class IInitializeCommandRoute : InitializeCommandRoute
  {
    #region Modified code
    protected override void RegisterRoutes(RouteCollection routes, PipelineArgs args)
    {
      string commandRoutePrefix = SpeakSettings.Mvc.CommandRoutePrefix;
      string[] namespaces = { "Sitecore.Controllers" };
      routes.MapRoute("Sitecore.Speak.Commands", commandRoutePrefix + "{controller}/{action}", namespaces);
      routes.MapRoute("Sitecore.Speak", "sitecore/shell/api/sitecore/{controller}/{action}", namespaces);
    }
    #endregion Modified code
  }
}