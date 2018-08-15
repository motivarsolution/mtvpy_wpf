using mtvpt_wpf.Model;
using mtvpt_wpf.Model.Internal;
using mtvpt_wpf.Utility;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtvpt_wpf.Controller
{
    public static class DatabaseConnection
    {
        public static SQLiteConnection sqlConnection = new SQLiteConnection();
        private static SQLiteCommand sqlCommand;
        //private static List<zSystem_Detail_Model> _zdmList = new List<zSystem_Detail_Model>();
        //private static zSystem_Detail_Model _zdm = new zSystem_Detail_Model();

        public static void SetConnection()
        {
            string DatabasePath = @"Database\SystemDB.db";
            string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string FullDatabasePath = Path.Combine(ProjectPath, DatabasePath);

            if (!File.Exists(FullDatabasePath))
            {
                GlobalFunctions.ShowDebug("Create Database");
                //Create Database
                sqlConnection = new SQLiteConnection("Data Source=" + FullDatabasePath + ";Version=3;");
            }
            else
            {
                sqlConnection = new SQLiteConnection("Data Source=" + FullDatabasePath + ";Version=3;");
            }

        }

        #region QuerySystem
        public static void querySystemDetail()
        {
            string CommandText = "SELECT * " +
                                 "FROM zSystem_Detail ";

            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            using (SQLiteCommand cmd = new SQLiteCommand(CommandText, DatabaseConnection.sqlConnection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        zSystemDetailModel.SYSTEM_ID = (rdr["SYSTEM_ID"].ToString());
                        zSystemDetailModel.SYSTEM_NAME = (rdr["SYSTEM_NAME"].ToString());
                        zSystemDetailModel.SYSTEM_FULLNAME = (rdr["SYSTEM_FULLNAME"].ToString());
                        zSystemDetailModel.SYSTEM_VERSION = (rdr["SYSTEM_VERSION"].ToString());
                        zSystemDetailModel.SYSTEM_VERSION_NAME = (rdr["SYSTEM_VERSION_NAME"].ToString());
                        zSystemDetailModel.SYSTEM_TIMEZONE = (rdr["SYSTEM_TIMEZONE"].ToString());
                        zSystemDetailModel.SYSTEM_LAST_SYNC_TIME = (rdr["SYSTEM_LAST_SYNC_TIME"].ToString());
                        zSystemDetailModel.SYSTEM_LAST_SYNC_DATE = (rdr["SYSTEM_LAST_SYNC_DATE"].ToString());
                    }
                }
            }

            sqlConnection.Close();
        }

        public static void queryzNumberRange()
        {
            string CommandText = "SELECT * " +
                                 "FROM zSystem_Detail ";

            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            using (SQLiteCommand cmd = new SQLiteCommand(CommandText, DatabaseConnection.sqlConnection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {

                    }
                }
            }

            sqlConnection.Close();
        }

        public static void querytsNumberRange()
        {
            string CommandText = "SELECT * " +
                                 "FROM zSystem_Detail ";

            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            using (SQLiteCommand cmd = new SQLiteCommand(CommandText, DatabaseConnection.sqlConnection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {

                    }
                }
            }

            sqlConnection.Close();
        }

        #endregion

        #region QueryLogin
        public static zAccountDetailModel queryLogin(LoginModel loginModel)
        {
            zAccountDetailModel zAccountDetailModel = new zAccountDetailModel();

            string CommandText = "SELECT * " +
                                 "FROM zAccount_Detail " +
                                 "WHERE " + 
                                 "account_username = '" + loginModel.login_username + "' " +
                                 "AND account_password ='" + loginModel.Login_password + "'";

            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            using (SQLiteCommand cmd = new SQLiteCommand(CommandText, DatabaseConnection.sqlConnection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if(rdr.HasRows != false)
                    {
                        while (rdr.Read())
                        {
                            zAccountDetailModel.account_id = (rdr["account_id"].ToString());
                            zAccountDetailModel.account_username = (rdr["account_username"].ToString());
                            zAccountDetailModel.account_password = (rdr["account_password"].ToString());
                            zAccountDetailModel.account_created_date = (rdr["account_created_date"].ToString());
                            zAccountDetailModel.account_created_by = (rdr["account_created_by"].ToString());
                            zAccountDetailModel.account_firstname = (rdr["account_firstname"].ToString());
                            zAccountDetailModel.account_lastname = (rdr["account_lastname"].ToString());
                            zAccountDetailModel.account_lastlogin_time = (rdr["account_lastlogin_time"].ToString());
                            zAccountDetailModel.account_lastlogin_date = (rdr["account_lastlogin_date"].ToString());
                            zAccountDetailModel.account_language_default = (rdr["account_language_default"].ToString());
                            zAccountDetailModel.account_role_id = (rdr["account_role_id"].ToString());
                            zAccountDetailModel.account_expire_date = (rdr["account_expire_date"].ToString());
                            zAccountDetailModel.account_status = (rdr["account_status"].ToString());
                        }
                    }
                    else
                    {
                        GlobalFunctions.ShowDebug("Incorrect");
                    }
                    
                }


            }

            sqlConnection.Close();

            return zAccountDetailModel;
        }

        public static zAccountDetailModel queryLoginUsername(LoginModel loginModel)
        {
            zAccountDetailModel zAccountDetailModel = new zAccountDetailModel();

            string CommandText = "SELECT * " +
                                 "FROM zAccount_Detail " +
                                 "WHERE " +
                                 "account_username = '" + loginModel.login_username + "'";

            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            using (SQLiteCommand cmd = new SQLiteCommand(CommandText, DatabaseConnection.sqlConnection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows != false)
                    {
                        
                    }
                    else
                    {
                        GlobalFunctions.ShowDebug("Incorrect");
                    }

                }
            }

            sqlConnection.Close();
        }


        public static void UpdateLoginTransaction(string user = "test01", string pass = "test00")
        {
            zAccountDetailModel zAccountDetailModel = new zAccountDetailModel();

            string CommandText = "SELECT * " +
                                 "FROM zAccount_Detail " +
                                 "WHERE " +
                                 "account_username = '" + user + "' " +
                                 "AND account_password ='" + pass + "'";

            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            using (SQLiteCommand cmd = new SQLiteCommand(CommandText, DatabaseConnection.sqlConnection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows != false)
                    {
                        while (rdr.Read())
                        {
                            zAccountDetailModel.account_id = (rdr["account_id"].ToString());
                            zAccountDetailModel.account_username = (rdr["account_username"].ToString());
                            zAccountDetailModel.account_password = (rdr["account_password"].ToString());
                            zAccountDetailModel.account_created_date = (rdr["account_created_date"].ToString());
                            zAccountDetailModel.account_created_by = (rdr["account_created_by"].ToString());
                            zAccountDetailModel.account_firstname = (rdr["account_firstname"].ToString());
                            zAccountDetailModel.account_lastname = (rdr["account_lastname"].ToString());
                            zAccountDetailModel.account_lastlogin_time = (rdr["account_lastlogin_time"].ToString());
                            zAccountDetailModel.account_lastlogin_date = (rdr["account_lastlogin_date"].ToString());
                            zAccountDetailModel.account_language_default = (rdr["account_language_default"].ToString());
                            zAccountDetailModel.account_role_id = (rdr["account_role_id"].ToString());
                            zAccountDetailModel.account_expire_date = (rdr["account_expire_date"].ToString());
                            zAccountDetailModel.account_status = (rdr["account_status"].ToString());
                        }
                    }
                    else
                    {
                        GlobalFunctions.ShowDebug("Incorrect");
                    }

                }
            }

            sqlConnection.Close();
        }

        #endregion

    }
}
