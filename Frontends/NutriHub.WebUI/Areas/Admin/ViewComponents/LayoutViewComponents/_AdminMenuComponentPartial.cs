﻿using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.ViewComponents.LayoutViewComponents
{
    public class _AdminMenuComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
