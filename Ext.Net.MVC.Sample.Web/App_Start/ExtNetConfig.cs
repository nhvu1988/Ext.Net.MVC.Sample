using System.Web.Mvc;
using System.Web.Routing;
 
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Ext.Net.MVC.Sample.Web.ExtNetConfig), "Start")]
namespace Ext.Net.MVC.Sample.Web 
{
    public static class ExtNetConfig 
    {
        public static void Start() 
        {
            ExtNetConfig.RegisterRoutes(RouteTable.Routes);
        }
 
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Ignore all ext.axd embedded resource paths
            routes.IgnoreRoute("{extnet-root}/{extnet-file}/ext.axd");
        }

        // If you use configure forms authentication in your Web.config and 
        // use <deny users="*"> to deny all requests, such as the following: 
        //
        //  <location>
        //    <system.web>
        //      <authorization>
        //        <deny users="*" />
        //      </authorization>
        //    </system.web>
        //  </location>
        //
        // Add the following Application_AuthenticateRequest event handler 
        // to your Global.asax.cs to exclude authenticating Ext.NET related 
        // resource files (.js, .css, images).
        // 
        //protected void Application_AuthenticateRequest(object sender, System.EventArgs e)
        //{
        //    // Skip authenticating all ext.axd embedded resources (.js, .css, images)
        //    if (HttpContext.Current.Request.FilePath.EndsWith("/ext.axd"))
        //    {
        //        HttpContext.Current.SkipAuthorization = true;
        //    }
        //}
    }
}