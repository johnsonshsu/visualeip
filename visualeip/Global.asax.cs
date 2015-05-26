using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace visualeip
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["ezAppNo"] = "EIP";
            Session["ezUserNo"] = "001";
            Session["ezUserName"] = "王小明";
            Session["ezCompNo"] = "001";
            Session["ezCompName"] = "小明電子";
            Session["ezConnName"] = "SQLCA";
            Session["ezConnString"] = "Data Source=.;Initial Catalog=xxxxx;User ID=sa;Password=xxxxx";
            Session["ezProviderName"] = "System.Data.SqlClient";
            Session["ezDbName"] = "visualeip";
            Session["ezDbDesc"] = "正式區";
            Session["ezLanguage"] = "en-US";
            Session["ezUserMode"] = "user";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}