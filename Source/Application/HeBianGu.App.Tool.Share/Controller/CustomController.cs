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

namespace HeBianGu.App.Tool
{
    [Controller("Custom")]
    internal class CustomController : Controller<CustomViewModel>
    {
        public async Task<IActionResult> Custom()
        {
            return await ViewAsync();
        }
    }
}
