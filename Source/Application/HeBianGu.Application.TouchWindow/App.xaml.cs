﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;


namespace HeBianGu.Application.TouchWindow
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : ApplicationBase
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShellWindow shellWindow = new ShellWindow();

            StartWindow startWindow = new StartWindow();

            Task.Run(() =>
            {
                Thread.Sleep(5000);

                this.Dispatcher.Invoke(() =>
                {
                    startWindow.Close();
                });
            });

            startWindow.ShowDialog();

            shellWindow.Show();

            AssemblyDomain.Instance.StartMonitor();

            var domain = this.IServiceCollection.GetService<IAssemblyDomain>();

            domain.StartMonitor();
        }


        protected override void ConfigureServices(IServiceCollection services)
        {
            //  Do：注册Mvc模式
            services.UseMvc();

            //  Do ：注入领域模型服务
            services.AddSingleton<IAssemblyDomain, AssemblyDomain>();

            //  Do ：注册本地化配置读写服务
            services.AddSingleton<IThemeLocalizeService, ThemeLocalizeService>();

            ////  Do ：注册日志服务
            //services.AddSingleton<ILogService, AssemblyDomain>();

        }

        protected override void Configure(IApplicationBuilder app)
        {
            //  Do：设置默认主题
            app.UseLocalTheme(l =>
            {
                l.AccentColor = (Color)ColorConverter.ConvertFromString("#FF003D99");
                //l.ForegroundColor = (Color)ColorConverter.ConvertFromString("#727272");

                l.SmallFontSize = 15D;
                l.LargeFontSize = 18D;
                l.FontSize = FontSize.Small;

                l.ItemHeight = 35;

                l.RowHeight = 60;

                l.ItemCornerRadius = 5;

                l.AnimalSpeed = 5000;

                l.AccentColorSelectType = 0;

                l.IsUseAnimal = false;

                l.ThemeType = ThemeType.Light;

                l.Language = Language.Chinese;

                l.AccentBrushType = AccentBrushType.LinearGradientBrush;
            });

            app.UseTheme(l => l.DialogCoverBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0)) { Opacity = 0.80 });
        }

    }
}
