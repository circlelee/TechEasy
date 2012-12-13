using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.Core.Common
{
    public sealed class Globals
    {
        // Fields
        public const int PAY_BALANCE_PAYMENTMODEID = -2;
        public const string PAY_SECURITY_CODE = "MATICSOFT_SENDING";
        public const string PAY_SECURITY_KEY = "MATICSOFT_SECURITY_CODE";
        public static decimal POINT_RATIO;
        public static string SESSIONKEY_ADMIN;
        public static string SESSIONKEY_AGENTS;
        public static string SESSIONKEY_ENTERPRISE;
        public static string SESSIONKEY_USER;

        static Globals()
        {
            SESSIONKEY_ADMIN = "Admin_UserInfo";
            SESSIONKEY_ENTERPRISE = "Enterprise_UserInfo";
            SESSIONKEY_AGENTS = "Agents_UserInfo";
            SESSIONKEY_USER = SESSIONKEY_AGENTS = SESSIONKEY_ENTERPRISE = SESSIONKEY_ADMIN = "UserInfo";
            POINT_RATIO = 1M;
        }

        private Globals()
        {
        }

        public static int SafeInt(string text, int defaultValue)
        {
            int num;
            if (int.TryParse(text, out num))
            {
                defaultValue = num;
            }
            return defaultValue;
        }

        public static bool IsPublicSession
        {
            get
            {
                return false;
            }
        }
 

    }
}
