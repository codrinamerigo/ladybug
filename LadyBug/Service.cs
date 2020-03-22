using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LadyBug
{
    /// <summary>
    /// Provides authentication functionality.
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Tries to authenticate the user with the given credentials.
        /// </summary>
        /// <param name="userName">UserName</param>
        /// <param name="password">User's password</param>
        /// <returns>true if the user has been successfully authenticated</returns>
        Task<bool> Login(string userName, string password);
    }

    /// <summary>
    /// UI-specific service providing abilities to show alert messages.
    /// </summary>
    public interface IAlertService
    {
        /// <summary>
        /// Show an alert message to the user.
        /// </summary>
        /// <param name="title">Alert message title</param>
        /// <param name="message">Alert message text</param>
        Task ShowAlert(string title, string message);
    }
}
