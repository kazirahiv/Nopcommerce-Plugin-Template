using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.NewPayment.Components
{
    [ViewComponent(Name = "NewPayment")]
    public class NewPaymentViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.NewPayment/Views/PaymentInfo.cshtml");
        }
    }
}
