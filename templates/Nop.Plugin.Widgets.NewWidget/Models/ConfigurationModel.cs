using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.NewWidget.Models
{
    public record ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NewWidget.Enable")]
        public bool Enable { get; set; }
        public bool Enable_OverrideForStore { get; set; }
    }
}