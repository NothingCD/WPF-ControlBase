﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace HeBianGu.Application.OfficeWindow
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : ApplicationBase
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ShellWindow shellWindow = new ShellWindow();

            shellWindow.Show();

            base.OnStartup(e);
        }


        protected override void ConfigureServices(IServiceCollection services)
        {
            //  Do：注册Mvc模式
            services.UseMvc();

            //  Do ：注册本地化配置读写服务
            services.AddSingleton<IThemeLocalizeService, LocalizeService>();

            //  Do ：注入领域模型服务
            services.AddSingleton<IAssemblyDomain, AssemblyDomain>();

            ////  Do ：注册日志服务
            //services.AddSingleton<ILogService, AssemblyDomain>();

        }

        protected override void Configure(IApplicationBuilder app)
        {
            //  Do：设置默认主题
            app.UseLocalTheme(l =>
            {
                l.AccentColor = (Color)ColorConverter.ConvertFromString("#FF003D99");

                l.SmallFontSize = 14D;
                l.LargeFontSize = 16D;
                l.FontSize = FontSize.Small;

                l.ItemHeight = 36;
                l.RowHeight = 40;
                //l.ItemWidth = 120;
                l.ItemCornerRadius = 2;

                l.AnimalSpeed = 5000;
                l.AccentColorSelectType = 0;
                l.IsUseAnimal = false;

                l.ThemeType = ThemeType.Light;

                l.Language = Language.Chinese;

                l.AccentBrushType = AccentBrushType.LinearGradientBrush;
            });
        }

    }
}
