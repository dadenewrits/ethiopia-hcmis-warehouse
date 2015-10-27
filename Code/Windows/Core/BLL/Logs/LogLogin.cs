
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using DAL;

namespace BLL
{
    /// <summary>
    /// 
    /// </summary>
	public class LogLogin : _LogLogin
	{
		public LogLogin()
		{
		
		}

        /// <summary>
        /// Adds the new.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="loginTime">The login time.</param>
        /// <param name="successfulLogin">if set to <c>true</c> [successful login].</param>
        /// <param name="hostName">Name of the host.</param>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="macAddress">The mac address.</param>
        /// <param name="unknownUser">if set to <c>true</c> [unknown user].</param>
        /// <param name="unknownUserName">Name of the unknown user.</param>
        /// <param name="applicationVersion">The application version.</param>
        public void AddNew(int? userID,DateTime loginTime,bool successfulLogin, string hostName,string ipAddress,string macAddress, bool unknownUser,string unknownUserName, string applicationVersion)
        {
            try //Why use a try, catch? Because the schema needs to be updated before it can be used and the schema update is available after the login. So, we don't want this to stop us from logging in.
            {
                this.AddNew();
                if (userID.HasValue)
                    this.UserID = userID.Value;
                this.LoginTime = loginTime;
                this.SuccesfulLogin = successfulLogin;
                this.HostName = hostName;
                this.IPAddress = ipAddress;
                this.MACAddress = macAddress;
                this.UnknownUser = unknownUser;
                this.UnknownUserName = unknownUserName;
                this.ApplicationVersion = applicationVersion;
                this.Save();
            }
            catch
            {
            }
        }
	}
}