using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.NewWidget.Models;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.NewWidget.Components
{
    [ViewComponent(Name = "WidgetsNewWidget")]
    public class WidgetsNewWidgetViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly ISettingService _settingService;
        public WidgetsNewWidgetViewComponent(IStoreContext storeContext, 
            ISettingService settingService)
        {
            _storeContext = storeContext;
            _settingService = settingService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            var store = await _storeContext.GetCurrentStoreAsync();
            var NewWidgetSettings = await _settingService.LoadSettingAsync<NewWidgetSettings>(store.Id);
            var model = new PublicInfoModel();

            return View("~/Plugins/Widgets.NewWidget/Views/PublicInfo.cshtml", model);
        }
    }
}
