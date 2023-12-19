using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day9AssignmentWebForm
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode=UnobtrusiveValidationMode.None;
            LblInfo.Visible = false;
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                LblInfo.Visible = true;
                LblInfo.Text = "Registration Done!!!  " + TxtName.Text;
                LblInfo.Text += "Your Mobile:  " + TxtMobile.Text;
                LblInfo.Text += "Your Email:  " + TxtEmail.Text;
                LblInfo.Text += "Password:   " + TxtPwd.Text;
            }

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string len = (args.Value);
            args.IsValid=len.Length > 6;

            
        }
    }
}