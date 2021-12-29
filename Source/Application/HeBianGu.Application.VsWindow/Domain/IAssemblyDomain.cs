﻿using HeBianGu.General.WpfControlLib;

namespace HeBianGu.Application.VsWindow
{
    public interface IAssemblyDomain
    {
        LoginViewModel GetAccountConfig();

        bool Login(string userName, string psd, bool IsSavePSD, out string err);
    }
}