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

namespace HeBianGu.App.Menu
{
    [Controller("Random")]
    internal class RandomController : Controller
    {
        public async Task<IActionResult> Random()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Grid()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Uniform()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Index()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Origin()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Easing()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Back()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Bounce()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Elastic()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Stack()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> HStack()
        {
            return await ViewAsync();
        }
    }
}
