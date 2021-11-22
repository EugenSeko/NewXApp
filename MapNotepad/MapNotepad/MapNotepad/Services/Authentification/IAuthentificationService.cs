﻿using MapNotepad.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MapNotepad.Services.Authentification
{
  public  interface IAuthentificationService
    {
        void Register(string username, string email);
        void RegisterAsync(string password);
        Task<ValidationResults> ValidateAsync(string username, string email);
        ValidationResults Validate(string password);
        Task<VerficationResult> VerificateAsync(string email, string password);
        Task Logout();


    }
}
