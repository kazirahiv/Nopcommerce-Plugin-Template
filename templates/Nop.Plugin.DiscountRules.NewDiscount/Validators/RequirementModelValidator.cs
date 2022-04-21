using System.Text.RegularExpressions;
using FluentValidation;
using Nop.Plugin.DiscountRules.NewDiscount.Models;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Plugin.DiscountRules.NewDiscount.Validators
{
    /// <summary>
    /// Represents an <see cref="RequirementModel"/> validator.
    /// </summary>
    public class RequirementModelValidator : BaseNopValidator<RequirementModel>
    {
        public RequirementModelValidator(ILocalizationService localizationService)
        {
            RuleFor(model => model.DiscountId)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Plugins.DiscountRules.NewDiscount.Fields.DiscountId.Required"));
        }
    }
}
