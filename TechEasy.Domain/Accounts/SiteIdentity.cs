using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Security.Cryptography;

namespace TechEasy.Domain.Accounts
{
    public class SiteIdentity : IIdentity
    {
        #region ...delete        
        //public SiteIdentity()
        //{ 
        
        //}
        //public SiteIdentity(int currentUserID)
        //{
        //    this.DepartmentID = "-1";
        //    DataRow userRow = this.dataUser.Retrieve(currentUserID);
        //    if (userRow != null)
        //    {
        //        this.LoadFromDR(userRow);
        //    }
        //}

        //public SiteIdentity(string currentUserName)
        //{
        //    this.DepartmentID = "-1";
        //    DataRow userRow = this.dataUser.Retrieve(currentUserName);
        //    if (userRow != null)
        //    {
        //        this.LoadFromDR(userRow);
        //    }
        //}

        //private void LoadFromDR(DataRow userRow)
        //{
        //    if (userRow != null)
        //    {
        //        this.UserID = (int)userRow["UserID"];
        //        this.userName = userRow["UserName"].ToString();
        //        this.trueName = userRow["TrueName"].ToString();
        //        this.activity = (bool)userRow["Activity"];
        //        this.userType = userRow["UserType"].ToString();
        //        this.password = (byte[])userRow["Password"];
        //        if (!object.Equals(userRow["Sex"], null) && !object.Equals(userRow["Sex"], DBNull.Value))
        //        {
        //            this.sex = userRow["Sex"].ToString();
        //        }
        //        if (!object.Equals(userRow["Phone"], null) && !object.Equals(userRow["Phone"], DBNull.Value))
        //        {
        //            this.phone = userRow["Phone"].ToString();
        //        }
        //        if (!object.Equals(userRow["Email"], null) && !object.Equals(userRow["Email"], DBNull.Value))
        //        {
        //            this.email = userRow["Email"].ToString();
        //        }
        //        if (!object.Equals(userRow["EmployeeID"], null) && !object.Equals(userRow["EmployeeID"], DBNull.Value))
        //        {
        //            this.employeeID = Convert.ToInt32(userRow["EmployeeID"]);
        //        }
        //        if (!object.Equals(userRow["DepartmentID"], null) && !object.Equals(userRow["DepartmentID"], DBNull.Value))
        //        {
        //            this.departmentID = userRow["DepartmentID"].ToString();
        //        }
        //        if (!object.Equals(userRow["Style"], null) && !object.Equals(userRow["Style"], DBNull.Value))
        //        {
        //            this.style = Convert.ToInt32(userRow["Style"]);
        //        }
        //        if (!object.Equals(userRow["User_iCreator"], null) && !object.Equals(userRow["User_iCreator"], DBNull.Value))
        //        {
        //            this._user_icreator = Convert.ToInt32(userRow["User_iCreator"]);
        //        }
        //        if (!object.Equals(userRow["User_dateCreate"], null) && !object.Equals(userRow["User_dateCreate"], DBNull.Value))
        //        {
        //            this._user_datecreate = Convert.ToDateTime(userRow["User_dateCreate"]);
        //        }
        //        if (!object.Equals(userRow["User_dateValid"], null) && !object.Equals(userRow["User_dateValid"], DBNull.Value))
        //        {
        //            this._user_datevalid = Convert.ToDateTime(userRow["User_dateValid"]);
        //        }
        //        if (!object.Equals(userRow["User_dateExpire"], null) && !object.Equals(userRow["User_dateExpire"], DBNull.Value))
        //        {
        //            this._user_dateexpire = Convert.ToDateTime(userRow["User_dateExpire"]);
        //        }
        //        if (!object.Equals(userRow["User_iApprover"], null) && !object.Equals(userRow["User_iApprover"], DBNull.Value))
        //        {
        //            this._user_iapprover = Convert.ToInt32(userRow["User_iApprover"]);
        //        }
        //        if (!object.Equals(userRow["User_dateApprove"], null) && !object.Equals(userRow["User_dateApprove"], DBNull.Value))
        //        {
        //            this._user_dateapprove = Convert.ToDateTime(userRow["User_dateApprove"]);
        //        }
        //        if (!object.Equals(userRow["User_iApproveState"], null) && !object.Equals(userRow["User_iApproveState"], DBNull.Value))
        //        {
        //            this._user_iapprovestate = Convert.ToInt32(userRow["User_iApproveState"]);
        //        }
        //        this._user_clang = userRow["User_cLang"].ToString();
        //    }
        //}
        #endregion

        //public int TestPassword(string password)
        //{
        //    byte[] bytes = new UnicodeEncoding().GetBytes(password);
        //    byte[] encPassword = new SHA1CryptoServiceProvider().ComputeHash(bytes);
        //    return this.dataUser.TestPassword(this.userID, encPassword);
        //}

        // Properties
        public bool Activity { get; set; }
        public string AuthenticationType { get; set; }
        public string DepartmentID { get; set; }
        public string Email { get; set; }
        public int EmployeeID { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Name { get; set;}
        public byte[] Password { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public int Style { get; set; }
        public string TrueName { get; set; }
        public string User_cLang { get; set; }
        public DateTime User_dateApprove { get; set; }
        public DateTime User_dateCreate { get; set; }
        public DateTime User_dateExpire { get; set; }
        public DateTime User_dateValid { get; set; }
        public int User_iApprover { get; set; }
        public int User_iApproveState { get; set; }
        public int User_iCreator { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }


    }
}
