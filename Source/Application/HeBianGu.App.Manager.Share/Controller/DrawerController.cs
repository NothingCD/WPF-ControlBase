﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using HeBianGu.Service.Mvc;

namespace HeBianGu.App.Manager
{
    [Controller("Drawer")]
    internal class DrawerController : Controller
    {
        public async Task<IActionResult> DrawerTranslate()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> DrawerScale()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Geomotry()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Other()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> DrawerOpacity()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Angle()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> GitTop()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Expander()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Panel()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Scroll()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Filter()
        {
            return await ViewAsync();
        }
    }
}
