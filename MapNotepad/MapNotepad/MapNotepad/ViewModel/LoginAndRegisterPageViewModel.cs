﻿using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MapNotepad.Helpers;
using Xamarin.Forms;

namespace MapNotepad.ViewModel
{
    class LoginAndRegisterPageViewModel : BaseViewModel
    {
        public LoginAndRegisterPageViewModel(INavigationService navigationService):base(navigationService)
        {
            LoginButtonTap = SingleExecutionCommand.FromFunc(GoToLoginPageAsync);
            RegisterButtonTap = SingleExecutionCommand.FromFunc(GoToRegisterPageAsync);  
        }

        #region --- Public Properties ---
        public ICommand LoginButtonTap { get; set; }
        public ICommand RegisterButtonTap { get; set; }
        #endregion
        #region --- Overrides ---
        #endregion
        #region --- Private Helpers ---
        #endregion
    }
}
