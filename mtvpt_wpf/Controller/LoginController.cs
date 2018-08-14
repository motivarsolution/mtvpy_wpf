using mtvpt_wpf.Model;
using mtvpt_wpf.Model.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtvpt_wpf.Controller
{
    public class LoginController
    {
        zAccountDetailModel zAccountDetailModel = new zAccountDetailModel();

        public LoginController()
        {
            //constructor
        }

        public zAccountDetailModel Login(string username , string password)
        {
            return null;
        }

        public zAccountDetailModel Login(LoginModel loginModel)
        {
            zAccountDetailModel = DatabaseConnection.queryLogin(loginModel);

            if (zAccountDetailModel == null)
            {
                //DatabaseConnection.queryLoginUsername(loginModel);
            }


            return null;
        }
    }
}
