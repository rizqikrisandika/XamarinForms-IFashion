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

using iFashion_3.Models;
using iFashion_3.Views;

namespace iFashion_3.Controllers
{
    
    class RegistController
    {
        // Reference
        private RegistModel _model;
        private RegistView _view;


        public RegistController(RegistModel model, RegistView view)
        {
            this._model = model;
            this._view = view;
        }

        public void isTrue()
        {
            if(_model.username == null || _model.username == "")
            {
                // PopUp username Kosong
            }
            else if(_model.email == null || _model.email == "")
            {
                // Popup Email Kosong
            }else if(_model.gender == null || _model.gender == "")
            {
                // PopUp gender Kosong
            }else if(_model.password == null || _model.password == "")
            {
                // Popup password Kosong
            }else if(_model.confirmPassword == null || _model.confirmPassword == "")
            {
                // Popup Confirm password kosong
            }else if(_model.password != _model.confirmPassword)
            {
                // Popup Password Tidak Sama
            }
            else
            {
                _view.createViewHome();
            }
        }
    }
}