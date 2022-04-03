using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.NewWidget.Models;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Widgets.NewWidget.Controllers
{
    [AuthorizeAdmin]
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class WidgetsNewWidgetController : BasePluginController
    {
        private readonly ILocalizationService _localizationService;
        private readonly INotificationService _notificationService;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;

        public WidgetsNewWidgetController(ILocalizationService localizationService,
            INotificationService notificationService,
            IPermissionService permissionService,
            ISettingService settingService,
            IStoreContext storeContext)
        {
            _localizationService = localizationService;
            _notificationService = notificationService;
            _permissionService = permissionService;
            _settingService = settingService;
            _storeContext = storeContext;
        }

        public async Task<IActionResult> Configure()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            //load settings for a chosen store scope
            var storeScope = await _storeContext.GetActiveStoreScopeConfigurationAsync();
            var NewWidgetSettings = await _settingService.LoadSettingAsync<NewWidgetSettings>(storeScope);
            var model = new ConfigurationModel
            {
                Enable = true,
                ActiveStoreScopeConfiguration = storeScope
            };

            if (storeScope > 0)
            {
                model.Enable_OverrideForStore = await _settingService.SettingExistsAsync(NewWidgetSettings, x => x.Enable, storeScope);
            }

            return View("~/Plugins/Widgets.NewWidget/Views/Configure.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Configure(ConfigurationModel model)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            //load settings for a chosen store scope
            var storeScope = await _storeContext.GetActiveStoreScopeConfigurationAsync();
            var NewWidgetSettings = await _settingService.LoadSettingAsync<NewWidgetSettings>(storeScope);

            NewWidgetSettings.Enable = model.Enable;

            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */
            await _settingService.SaveSettingOverridablePerStoreAsync(NewWidgetSettings, x => x.Enable, model.Enable_OverrideForStore, storeScope, false);

            //now clear settings cache
            await _settingService.ClearCacheAsync();

            _notificationService.SuccessNotification(await _localizationService.GetResourceAsync("Admin.Plugins.Saved"));
            
            return await Configure();
        }
    }
}