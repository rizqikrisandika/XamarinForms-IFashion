using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace iFashion_3.Models
{
    class LoginModel
    {
        private string _username;
        private string _password;

        public string username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        public string password
        {
            get { return this._password; }
            set { this._password = value; }
        }
     }
}