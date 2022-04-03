using Nop.Core;
using Nop.Core.Caching;

namespace Nop.Plugin.Misc.NewMisc
{
    /// <summary>
    /// Represents plugin constants
    /// </summary>
    public static class NewMiscDefaults
    {
        /// <summary>
        /// Gets a name of the view component to embed tracking script on pages
        /// </summary>
        public const string TRACKING_VIEW_COMPONENT_NAME = "WidgetsNewMisc";

        /// <summary>
        /// Gets a plugin system name
        /// </summary>
        public static string SystemName => "Misc.NewMisc";

        /// <summary>
        /// Gets a plugin partner name
        /// </summary>
        public static string PartnerName => "NOPCOMMERCE";

    }
}