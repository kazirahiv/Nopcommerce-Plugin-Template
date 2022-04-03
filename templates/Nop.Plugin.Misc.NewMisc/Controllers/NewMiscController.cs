using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Messages;
using Nop.Plugin.Misc.NewMisc.Models;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Messages;
using Nop.Services.Stores;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Models.Extensions;
using Nop.Web.Framework.Mvc;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Misc.NewMisc.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class NewMiscController : BasePluginController
    {
        #region Fields

        private readonly IGenericAttributeService _genericAttributeService;
        private readonly ILocalizationService _localizationService;
        private readonly ILogger _logger;
        private readonly INotificationService _notificationService;


        #endregion

        #region Ctor

        public NewMiscController(
            IGenericAttributeService genericAttributeService,
            ILocalizationService localizationService,
            ILogger logger,
            INotificationService notificationService)
        {
            _genericAttributeService = genericAttributeService;
            _localizationService = localizationService;
            _logger = logger;
            _notificationService = notificationService;
        }

        #endregion


        #region Methods

        [AuthorizeAdmin]
        [Area(AreaNames.Admin)]
        public async Task<IActionResult> Configure()
        {
            var model = new ConfigurationModel();
            return View("~/Plugins/Misc.NewMisc/Views/Configure.cshtml", model);
        }

        [AuthorizeAdmin]
        [Area(AreaNames.Admin)]
        [HttpPost, ActionName("Configure")]
        [FormValueRequired("save")]
        public async Task<IActionResult> Configure(ConfigurationModel model)
        {
            if (!ModelState.IsValid)
                return await Configure();

            _notificationService.SuccessNotification(await _localizationService.GetResourceAsync("Admin.Plugins.Saved"));

            return await Configure();
        }

        #endregion
    }
}