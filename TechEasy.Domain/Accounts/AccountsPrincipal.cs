using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Collections;
using TechEasy.Domain.Services;

namespace TechEasy.Domain.Accounts
{
    public class AccountsPrincipal : IPrincipal
    {
        // Fields
        protected IIdentity identity;
        protected List<int> permissionListid;
        protected List<string> permissionsDesc;
        protected ArrayList roleList;
        private string userName;
        public AccountsPrincipal()
        { 

        }
        
        //public AccountsPrincipal(int userID)
        //{
        //    this.permissionsDesc = new List<string>();
        //    this.permissionListid = new List<int>();
        //    this.identity = new SiteIdentity(userID);
        //    this.permissionLists = this.dataUser.GetEffectivePermissionLists(userID);
        //    if (this.permissionLists.Tables.Count > 0)
        //    {
        //        foreach (DataRow row in this.permissionLists.Tables[0].Rows)
        //        {
        //            this.permissionListid.Add(Convert.ToInt32(row["PermissionID"]));
        //            this.permissionsDesc.Add(row["Description"].ToString());
        //        }
        //    }
        //    this.roleList = this.dataUser.GetUserRoles(userID);
        //}

        //public AccountsPrincipal(string userName)
        //{
        //    this.permissionsDesc = new List<string>();
        //    this.permissionListid = new List<int>();
        //    this.identity = new SiteIdentity(userName);
        //    this.permissionLists = this.dataUser.GetEffectivePermissionLists(((SiteIdentity)this.identity).UserID);
        //    if (this.permissionLists.Tables.Count > 0)
        //    {
        //        foreach (DataRow row in this.permissionLists.Tables[0].Rows)
        //        {
        //            this.permissionListid.Add(Convert.ToInt32(row["PermissionID"]));
        //            this.permissionsDesc.Add(row["Description"].ToString());
        //        }
        //    }
        //    this.roleList = this.dataUser.GetUserRoles(((SiteIdentity)this.identity).UserID);
        //}

        public static byte[] EncryptPassword(string password)
        {
            byte[] bytes = new UnicodeEncoding().GetBytes(password);
            SHA1 sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(bytes);
        }

        public bool HasPermission(string permission)
        {
            return this.permissionsDesc.Contains(permission);
        }

        public bool HasPermissionID(int permissionid)
        {
            return this.permissionListid.Contains(permissionid);
        }

        public bool IsInRole(string role)
        {
            return this.roleList.Contains(role);
        }

        //public static AccountsPrincipal ValidateLogin(string userName, string password)
        //{
        //    byte[] encPassword = EncryptPassword(password);
        //    User user = new User();
        //    int userID = user.ValidateLogin(userName, encPassword);
        //    if (userID > 0)
        //    {
        //        return new AccountsPrincipal(userID);
        //    }
        //    return null;
        //}

        //public static AccountsPrincipal ValidateLogin4Email(string email, string password)
        //{
        //    byte[] encPassword = EncryptPassword(password);
        //    User user = new User();
        //    int userID = user.ValidateLogin4Email(email, encPassword);
        //    if (userID > 0)
        //    {
        //        return new AccountsPrincipal(userID);
        //    }
        //    return null;
        //}
        // Properties
        public IIdentity Identity { get; set; }
        //public DataSet PermissionLists { get; }
        public List<string> PermissionsDesc { get; set; }
        public List<int> PermissionsID { get; set;}
        public ArrayList Roles { get;set; }

    }
}
