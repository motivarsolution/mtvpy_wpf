using mtvpt_wpf.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtvpt_wpf.Constants
{
    public static class Messages
    {
        public static string m_login_success = "Login success!";

        public static string m_pass_inc = "Incorrect password. Please try again.";

        public static string m_user_or_pass_inc = "Incorrect username or password. Please try again.";

        public static string m_user_not_exist = "Username is not exist in system. Please contact administrator.";

        public static string m_insert_success = "Insert success!";

        public static string m_update_success = "Update success!";

        private static string test;

        public static string Test
        {
            get {
                if (GlobalVariables.SYSTEM_LANGUEGE == "TH")
                {
                    return "สวัสดี";
                }
                else
                {
                    return "Hello";
                }
            }
            set { test = value; }
        }

    }
}
