using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.NewPayment.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {

        }

        public int Priority => -1;
    }
}