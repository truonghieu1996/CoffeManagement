using System;
using System.Data;
using System.Collections.Generic;

using DTO;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
        }

        public bool CheckLogin(Account account)
        {
            string query = "USP_Login @UserName , @Password";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.UserName, account.Password});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }

        public DataTable GetAllAcount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllAccount");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @UserName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(string userName, string displayName, int typeID)
        {
            string query = string.Format("USP_InsertAccount @UserName , @DisplayName , @TypeID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, typeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("USP_ResetPassword @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool Delete(string userName)
        {
            string query = string.Format("USP_DeleteAccount @UserName");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            string query = "USP_UpdateAccount @UserName , @DisplayName , @Password , @NewPass";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { userName, displayName, password, newPass });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public DataTable SearchAccountByUserName(string userName)
        {

            string query = string.Format("USP_SearchAccountByUserName @UserName");

            DataTable table = new DataTable();
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}