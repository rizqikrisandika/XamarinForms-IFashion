using System;
using System.Collections.Generic;
using System.Linq;
using Android.OS;
using System.Text;
using iFashion_3.Models;
using iFashion_3.Views;

namespace iFashion_3.Controllers
{
    class LoginController
    {
        private LoginModel _model;
        private LoginView _view;

        public LoginController(LoginModel model, LoginView view)
        {
            this._model = model;
            this._view = view;
        }
        public void createLoginView(Bundle savedInstanceState)
        {
            
            _view.creteView(savedInstanceState);

        }

        public void readDatabase(string username, string password)
        {
            if(username == "admin" && password =="123" )
            {
                _view.createHomeview();
            }
            else
            {
                _view.showError();
            }
        }

    }
}