﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebAppTest
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpFileCollection file = Request.Files;
            var avatarFile = Request.Files[0];
            var avatarExt = Path.GetExtension(avatarFile.FileName);
            avatarFile.SaveAs(Server.MapPath("/upload") + "/" + DateTime.Now.ToString("yyyyMMddHHmmss") + avatarExt);


            Response.Write("{\"file\":\"lww\"}");//{"firstName":"Brett"}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //BLL.UserBLL u=new BLL.UserBLL();
            //Button1.Text = u.GetUser().Name;
        }

        
    }
}