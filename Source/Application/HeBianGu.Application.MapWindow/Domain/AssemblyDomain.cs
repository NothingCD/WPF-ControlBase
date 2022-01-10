﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Application.MapWindow
{
    public class AssemblyDomain : IAssemblyDomain
    { 
        public LoginViewModel GetAccountConfig()
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            //loginViewModel.LoginUseName = "HeBianGu";
            loginViewModel.LoginUseName = "admin";

            loginViewModel.LoginPassWord = "89757";

            loginViewModel.Remenber = true;

            return loginViewModel;
        }

        Random r = new Random();
        public bool Login(string userName, string psd, bool IsSavePSD, out string err)
        {
            err = string.Empty;

            if (r.Next(5) == 1)
            {
                err = "运气不佳，请再来一次";
                return false;
            }
            else
            {
                return true;
            }


        }

    }
}