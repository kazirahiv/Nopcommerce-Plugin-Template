using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Payments;
using Nop.Services.Logging;
using Nop.Services.Orders;
using Nop.Services.Payments;
using System.Threading.Tasks;

namespace Nop.Plugin.Payments.NewPayment.Controllers
{
    public class NewPaymentIpnController : Controller
    {
        #region Fields

        private readonly ILogger _logger;
        private readonly IOrderProcessingService _orderProcessingService;
        private readonly IOrderService _orderService;
        private readonly IPaymentPluginManager _paymentPluginManager;

        #endregion

        #region Ctor

        public NewPaymentIpnController(ILogger logger,
            IOrderProcessingService orderProcessingService,
            IOrderService orderService,
            IPaymentPluginManager paymentPluginManager)
        {
            _logger = logger;
            _orderProcessingService = orderProcessingService;
            _orderService = orderService;
            _paymentPluginManager = paymentPluginManager;
        }

        #endregion

        #region Utilities

        protected virtual async Task ProcessRecurringPaymentAsync(string invoiceId, PaymentStatus newPaymentStatus, string transactionId, string ipnInfo)
        {
        }

        protected virtual async Task ProcessPaymentAsync(string orderNumber, string ipnInfo, PaymentStatus newPaymentStatus, decimal mcGross, string transactionId)
        {
        }

        #endregion

        #region Methods

        public async Task<IActionResult> IPNHandler()
        {
            return Ok();
        }

        #endregion
    }
}