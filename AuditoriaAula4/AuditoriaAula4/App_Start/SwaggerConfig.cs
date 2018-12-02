using System.Web.Http;
using WebActivatorEx;
using AuditoriaAula4;
using Swashbuckle.Application;

namespace AuditoriaAula4
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
                 {
                     c.SingleApiVersion("v1", "Swagger Sample");
                     c.IncludeXmlComments(GetXmlCommentsPath());
                 })
                .EnableSwaggerUi(c =>
                {

                });
        }

        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\AuditoriaAula4.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
