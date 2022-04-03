using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Payments.NewPayment.Models
{
    public record ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Payments.NewPayment.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }
        public bool UseSandbox_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.NewPayment.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.NewPayment.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}