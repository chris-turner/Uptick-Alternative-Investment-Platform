using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Uptick.Models
{
    public class AppState
    {
        public User loggedInUser { get; set; }

        public event Action OnUserChange;

        public List<Asset> portfolio { get; set; }

        public List<Break> breaks { get; set; }

        public List<Asset> withdraw { get; set; }

        public string redirectUrl { get; set; }

        public void loginUser(string userName)
        {
            if(String.IsNullOrEmpty(userName.Trim()))
			{
                return;
			}
            User user = new User();
            user.username = userName;
            loggedInUser = user;
            OnUserChange?.Invoke();
        }

        public void logoutUser()
        {
            loggedInUser = null;
            OnUserChange?.Invoke();
        }

    }
}
