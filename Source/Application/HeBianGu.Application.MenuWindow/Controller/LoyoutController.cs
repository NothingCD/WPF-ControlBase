﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Application.MenuWindow
{
    [Controller("Loyout")]
    internal class LoyoutController : Controller<LoyoutViewModel>
    {
        public async Task<IActionResult> Home()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Fluid()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> MouseDrag()
        {
            return await ViewAsync();
        }
    }
}
