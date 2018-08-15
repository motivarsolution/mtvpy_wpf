using mtvpt_wpf.Model;
using mtvpt_wpf.Model.Internal;
using mtvpt_wpf.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace mtvpt_wpf.Controller
{
    public static class LoginController
    {
        private static LoginMessage loginMessage;
        private static ReturnStatusModel returnStatusModel;

        public static LoginMessage Login(LoginModel loginModel)
        {
            loginMessage = DatabaseConnection.queryLogin(loginModel);

            if (loginMessage.returnStatusModel.status == false)
            {
                loginMessage = DatabaseConnection.queryLoginUsername(loginModel);
            }

            CreateLoginTransaction(loginMessage);

            return loginMessage;
        }

        public static void CreateLoginTransaction(LoginMessage loginMessage)
        {
            tsNumberRangeModel newNumberRange = new tsNumberRangeModel() {
                login_id = (Int32.Parse(DatabaseConnection.querytsNumberRange().login_id) + 1).ToString()
            };

            tsLoginDetailModel tsLoginDetailModel = new tsLoginDetailModel() {

                login_id = newNumberRange.login_id,
                login_account_id = loginMessage.zAccountDetailModel.account_id,
                login_username = loginMessage.zAccountDetailModel.account_username,
                login_time = DateTime.Now.ToString("HHmm"),
                login_date = DateTime.Now.Date.ToString("ddMMyyyy"),
                login_ip = GlobalFunctions.GetIPAddress(),
                login_token = "null",
                login_status = loginMessage.returnStatusModel.status.ToString()

            };

            DatabaseConnection.inserttsLoginDetail(tsLoginDetailModel);
            returnStatusModel = DatabaseConnection.updatetsNumberRange(newNumberRange);

            if (GlobalFunctions.isNotError(returnStatusModel.status))
            {
                GlobalFunctions.ShowDebug("COMPLETED");
            }

        }
    }


}
