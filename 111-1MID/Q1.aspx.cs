using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q1 : System.Web.UI.Page {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void tb_Account_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < s_IdSet.Length; i++)
            {
                if (tb_Account.Text == s_IdSet[i] && tb_Account.Text != "")
                {
                    lb_Type.Text = "複診";
                    btn_Submit.Visible = true;
                    break;
                }
                else if (tb_Account.Text != s_IdSet[i] && tb_Account.Text != "")
                {
                    lb_Type.Text = "初診";
                    btn_Submit.Visible = true;

                }
                else
                {
                    btn_Submit.Visible = false;
                    lb_Type.Text = "初診";
                }
            }
            pl_Msg.Visible = false;
        }
        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            pl_Msg.Visible = true;
            lb_Msg.Text = "";
            if (tb_Phone.Text == "")
            {
                lb_Msg.Text += lb_Type.Text + "<br />" + tb_Account.Text + "先生/小姐，已完成掛號。" + "<br />" ;
            }
            else
            {
                lb_Msg.Text += lb_Type.Text + "<br />" + tb_Account.Text + "先生/小姐，已完成掛號。" + "<br />" + "連絡電話為" + tb_Phone.Text + "<br />" ;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lb_Type.Text = "初診";
            rd_Id.Checked = true;
            tb_Account.Text = "";
            tb_Phone.Text = "";
            btn_Submit.Visible = false;
            pl_Msg.Visible = false;
        }
    }
}