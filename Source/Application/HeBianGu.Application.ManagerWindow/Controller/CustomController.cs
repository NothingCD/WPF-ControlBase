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

namespace HeBianGu.Application.ManagerWindow
{
    [Controller("Custom")]
    internal class CustomController : Controller
    {
        public async Task<IActionResult> Home()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> PropertyGrid()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Shuttle()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Ping()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Step()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> LeftMenu()
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

        public async Task<IActionResult> Explorer()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ExplorerTree()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> FilterColumn()
        {
            return await ViewAsync();
        }
        
    }
}
