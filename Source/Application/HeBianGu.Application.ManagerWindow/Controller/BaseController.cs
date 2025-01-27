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
    [Controller("Base")]
    internal class BaseController : Controller
    {
        public async Task<IActionResult> Button()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> TextBlock()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Label()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> TextBox()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ComboBox()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> DatePicker()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> CheckBox()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> RadioButton()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ToggleButton()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Slider()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ProgressBar()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ToolTip()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ContextMenu()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Menu()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> Expander()
        {
            return await ViewAsync();
        }


        public async Task<IActionResult> ListBox()
        {
            return await ViewAsync();
        }


        public async Task<IActionResult> DataGrid()
        {
            return await ViewAsync();
        }


        public async Task<IActionResult> TreeView()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> TabControl()
        {
            return await ViewAsync();
        }

        public async Task<IActionResult> ToolBar()
        {
            return await ViewAsync();
        }
    }
}
