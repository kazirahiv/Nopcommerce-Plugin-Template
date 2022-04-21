using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.DiscountRules.NewDiscount.Models
{
    public record RequirementModel
    {
        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}